using Otopark.Data.Entities;
using Otopark.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Otopark.Service
{
    public interface IBrandService
    {
        List<Brand> Get();
        Brand GetById(int id);
        ServiceResult Post(Brand brand);
        ServiceResult Put(Brand brand);
        ServiceResult Delete(int id);


    }
    public class BrandService : IBrandService
    {
        private readonly CarParkDbContext context;
        public BrandService(CarParkDbContext context)
        {
            this.context = context;
        }
        public List<Brand> Get()
        {
            return context.Brands.ToList();
        }

        public Brand GetById(int id)
        {
            var brand = context.Brands
                .Include(x => x.Series)
                .FirstOrDefault(x => x.Id == id);
            return brand;
        }

        public ServiceResult Post(Brand brand)
        {
            var result = new ServiceResult { IsSuccess = true };
            context.Brands.Add(brand);
            context.SaveChanges();
            return result;
        }

        public ServiceResult Put(Brand brand)
        {
            var result = new ServiceResult { IsSuccess = false };
            var data = GetById(brand.Id);
            if (data != null)
            {
                data.BrandName = brand.BrandName;
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }

        public ServiceResult Delete(int id)
        {
            var result = new ServiceResult { IsSuccess = false };
            var brand = GetById(id);
            if (brand.Series.Count>0)
            {
                result.Message = "Serisi olan markalar silinemez";
                return result;
            }

            if (brand != null)
            {
                context.Brands.Remove(brand);
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }


    }
}
