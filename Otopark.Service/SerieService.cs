using Otopark.Data.Entities;
using Otopark.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace Otopark.Service
{
    public interface ISerieService
    {
        List<SerieModel> Get();
        SerieModel Get(int id);
        List<Serie> GetByBrandId(int brandId);
        ServiceResult Post(SerieModel serie);
        ServiceResult Put(SerieModel serie);
        ServiceResult Delete(int id);
    }
    public class SerieService : ISerieService
    {
        private readonly CarParkDbContext context;
        public SerieService(CarParkDbContext context)
        {
            this.context = context;
        }

        public List<SerieModel> Get()
        {
            var list = context.Series
                .Include(x => x.Brand)
                .Select(x => new SerieModel
                {
                    BrandName = x.Brand.BrandName,
                    SerieName = x.SerieName,
                    BrandId = x.BrandId,
                    Id = x.Id
                }).ToList();

            return list;
        }

        public SerieModel Get(int id)
        {
            var serie = context.Series
                .Select(x => new SerieModel
                {
                    BrandName = x.Brand.BrandName,
                    SerieName = x.SerieName,
                    BrandId = x.BrandId,
                    Id = x.Id
                })
                .FirstOrDefault(x => x.Id == id);
            return serie;
        }

        public List<Serie> GetByBrandId(int brandId)
        {
            var bringSerie = context.Series.Where(x => x.BrandId == brandId).ToList();
            return bringSerie;
        }

        public ServiceResult Post(SerieModel model)
        {
            var result = new ServiceResult { IsSuccess = true };
            var serie = new Serie
            {
                BrandId = model.BrandId,
                SerieName = model.SerieName
            };
            context.Series.Add(serie);
            context.SaveChanges();
            return result;
        }

        public ServiceResult Put(SerieModel model)
        {
            var result = new ServiceResult { IsSuccess = false };
            var serie = context.Series.FirstOrDefault(x => x.Id == model.Id);
            if (serie != null)
            {
                serie.SerieName = model.SerieName;
                serie.BrandId = model.BrandId;
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }
        public ServiceResult Delete(int id)
        {
            var result = new ServiceResult { IsSuccess = false };
            var model = context.Series.FirstOrDefault(x => x.Id == id);
            if (model != null)
            {
                context.Series.Remove(model);
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }


    }
}
