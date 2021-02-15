using Otopark.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Otopark.Data.Models;

namespace Otopark.Service
{
    public interface ICustomerService
    {
        List<CustomerModel> Get();
        Customer Get(int id);
        ServiceResult Post(Customer customer);
        ServiceResult Put(Customer customer);

        ServiceResult Delete(int id);

    }
    public class CustomerService : ICustomerService
    {
        private readonly CarParkDbContext context;
        public CustomerService(CarParkDbContext context)
        {
            this.context = context;
        }
        public List<CustomerModel> Get()
        {
            var list = context.Customers
                       .Include(x => x.Brand)
                       .Include(x => x.Serie)
                       .Include(x => x.CarParkingSpaces)
                       .Where(x => !x.Deleted)
                       .Select(x => new CustomerModel
                       {
                           Id = x.Id,
                           NameSurname = x.NameSurname,
                           Plaque = x.Plaque,
                           SerieName = x.Serie.SerieName,
                           BrandName = x.Brand.BrandName,
                           ParkingSpaces = x.CarParkingSpaces.ParkingSpaces,
                           Color = x.Color,
                           Comment = x.Comment,
                           EntryDate = x.EntryDate,
                           Telephone = x.Telephone,
                           Year = x.Year
                       }).ToList();
            return list;
        }
        public Customer Get(int id)
        {
            var customer = context.Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public ServiceResult Delete(int id)
        {
            var result = new ServiceResult { IsSuccess = false };
            var customer = context.Customers
                                   .Include(x => x.CarParkingSpaces)
                                   .FirstOrDefault(x => x.Id == id);

            if (customer != null)
            {
                customer.Deleted = true;
                if (customer.CarParkingSpaces != null)
                {
                    customer.CarParkingSpaces.Status = false;
                }
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }


        public ServiceResult Post(Customer model)
        {
            var result = new ServiceResult { IsSuccess = true };
            var isExist = context.Customers
                              .Any(x => x.Plaque.ToUpper() == model.Plaque.ToUpper() && !x.Deleted);

            if (isExist)
            {
                result.Message = "Plaka ile daha önce kayıt mevcuttur";
                return result;
            }
            else
            {
                model.Deleted = false;
                context.Customers.Add(model);
                context.SaveChanges();
                return result;
            }
        }

        public ServiceResult Put(Customer model)
        {
            var result = new ServiceResult { IsSuccess = false };
            var isExist = context.Customers
                              .Any(x => x.Plaque.ToUpper() == model.Plaque.ToUpper() && !x.Deleted && x.Id != model.Id);

            if (isExist)
            {
                result.Message = "Plaka ile daha önce kayıt mevcuttur";
                return result;
            }

            var customer = context.Customers
                    .FirstOrDefault(x => x.Id == model.Id);

            if (customer != null)
            {
                customer.Plaque = model.Plaque;
                customer.NameSurname = model.NameSurname;
                customer.Telephone = model.Telephone;
                customer.BrandId = model.BrandId;
                customer.SerieId = model.SerieId;
                customer.Year = model.Year;
                customer.Color = model.Color;
                customer.Comment = model.Comment;

                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }
    }
}


