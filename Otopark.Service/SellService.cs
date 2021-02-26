using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Otopark.Service
{
    public interface ISellService
    {
        SellModel PayDetails(int carParkSpaceId);
        ServiceResult Post(SellModel sell);
    }
    public class SellService : ISellService
    {
        private readonly CarParkDbContext context;


        public SellService(CarParkDbContext context)
        {
            this.context = context;
        }

        public List<Sell> Get()
        {
            throw new NotImplementedException();
        }

        public SellModel PayDetails(int carParkSpaceId)
        {
            var model = new SellModel();
            var customer = context.Customers
                      .Include(x => x.Brand)
                      .Include(x => x.Serie)
                      .Include(x => x.CarParkingSpaces)
                      .FirstOrDefault(x => x.CarParkingSpaceId == carParkSpaceId);

            if (customer != null)
            {
                model.NameSurname = customer.NameSurname;
                model.Plaque = customer.Plaque;
                model.Telephone = customer.Telephone;
                model.BrandName = customer.Brand.BrandName;
                model.SerieName = customer.Serie.SerieName;
                model.Color = customer.Color;
                model.Year = customer.Year;
                model.CustomerId = customer.Id;
                model.CarParkingSpaceId = customer.CarParkingSpaceId;
                model.ParkingSpaces = customer.CarParkingSpaces == null ? "" : customer.CarParkingSpaces.ParkingSpaces;

                model.EntryDate = customer.EntryDate.HasValue ? customer.EntryDate.Value.ToString("dd.MM.yyyy HH:mm") : "";

                model.ExitDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                var minute = (DateTime.Now - customer.EntryDate.Value).TotalMinutes;

                double hour = minute / 60;
                model.Hour = hour;
                var tariff = context.Tariffs
                     .FirstOrDefault(x => x.StartHour < hour && x.EndHour >= hour);

                if (tariff != null)
                {
                    model.Amount = tariff.Amount;

                    int intHour = (int)((minute + 1) / 60);
                    int remainMinute = (int)(minute - intHour * 60);
                    model.Time = intHour > 0 ? (intHour.ToString() + " saat " + remainMinute.ToString() + " dakika") : (remainMinute.ToString() + " dakika");
                }
            }
            return model;
        }

        public ServiceResult Post(SellModel sell)
        {
            var result = new ServiceResult { IsSuccess = false };
            var customer = context.Customers
                           .Include(x => x.CarParkingSpaces)
                           .FirstOrDefault(x => x.Id == sell.CustomerId);

            if (customer != null)
            {
                if (sell != null)
                {
                    var model = new Sell
                    {
                        Amount = sell.Amount,
                        CarParkingSpaceId = customer.CarParkingSpaceId.Value,
                        CustomerId = customer.Id,
                        EntryDate = customer.EntryDate.Value,
                        ExitDate = DateTime.Now,
                        Time = (decimal)sell.Hour
                    };
                    context.Sells.Add(model);

                    customer.CarParkingSpaceId = null;
                    customer.EntryDate = null;
                    customer.CarParkingSpaces.Status = false;
                    context.SaveChanges();
                    result.IsSuccess = true;
                }
            }
            else
            {
                result.Message = "Müşteri Bulunamadı!";
            }
            return result;
        }
    }
}
