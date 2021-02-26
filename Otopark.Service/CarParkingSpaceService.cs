using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Service
{
    public interface ICarParkingSpaceService
    {
        List<CarParkingSpace> Get();
        CarParkingSpace Get(int id);
        ServiceResult Post(CarParkingSpace model);
        ServiceResult Put(CarParkingSpace model);
        ServiceResult Delete(int id);
        ServiceResult ChangeStatus(ChangeStatusModel model);
     //   ServiceResult GetPlaque(ChangeStatusModel model);
    }
    public class CarParkingSpaceService : ICarParkingSpaceService
    {
        private readonly CarParkDbContext context;
        public CarParkingSpaceService(CarParkDbContext context)
        {
            this.context = context;
        }

        public List<CarParkingSpace> Get()
        {
            var parkSpaces = context.CarParkingSpaces.ToList();
            return parkSpaces;
        }

        public CarParkingSpace Get(int id)
        {
            var parkSpaces = context.CarParkingSpaces.FirstOrDefault(x => x.Id == id);
            return parkSpaces;
        }

        public ServiceResult Post(CarParkingSpace model)
        {
            var result = new ServiceResult { IsSuccess = true };
            model.Status = false;
            context.CarParkingSpaces.Add(model);
            context.SaveChanges();
            return result;
        }

        public ServiceResult Put(CarParkingSpace model)
        {
            var result = new ServiceResult { IsSuccess = false };
            var data = context.CarParkingSpaces.FirstOrDefault(x => x.Id == model.Id);
            if (data != null && model != null)
            {
                data.ParkingSpaces = model.ParkingSpaces;
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }

        public ServiceResult Delete(int id)
        {
            var result = new ServiceResult { IsSuccess = false };
            var data = context.CarParkingSpaces.Find(id);
            if (data.Status)
            {
                result.Message = "Park yeri DOLU olduğu için silinemez";
                return result;
            }
            if (data != null)
            { 
                context.CarParkingSpaces.Remove(data);
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }

        public ServiceResult ChangeStatus(ChangeStatusModel model)
        {
            var result = new ServiceResult { IsSuccess = false };
            var carParkSpace = context.CarParkingSpaces.Find(model.CarParkSpaceId);
            if (carParkSpace != null)
            {
                if (carParkSpace.Status)
                {
                    result.Message = "Park Yeri doludur.";
                    return result;
                }
                carParkSpace.Status = true;
            }
            else
            {
                return result;
            }
            var customer = context.Customers.FirstOrDefault(x => x.Id == model.CustomerId && !x.Deleted);
            if (customer != null)
            {
                if (customer.CarParkingSpaceId != null)
                {
                    result.Message = "Müşteri farklı bir park yerinde kayıtlıdır.";
                    return result;
                }
                customer.CarParkingSpaceId = model.CarParkSpaceId;
                customer.EntryDate = DateTime.Now;
            }
            else
            {
                return result;
            }
            context.SaveChanges();
            result.IsSuccess = true;
            return result;
        }

        //public ServiceResult GetPlaque(ChangeStatusModel model)
        //{
        //    var data = context.Customers.FirstOrDefault(x => x.Plaque == model.CarParkSpaceId);
        //    return data;

        //}
    }
}
