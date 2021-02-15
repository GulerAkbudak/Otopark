using Otopark.Data.Entities;
using Otopark.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Otopark.Service
{
    public interface ITariffService
    {
        List<Tariff> Get();
        Tariff GetById(int id);
        ServiceResult Post(Tariff tariff);
        ServiceResult Put(Tariff tariff);
        ServiceResult Delete(int id);
    }

    public class TariffService : ITariffService
    {
        private readonly CarParkDbContext context;
        public TariffService(CarParkDbContext context)
        {
            this.context = context;
        }

        public List<Tariff> Get()
        {
            return context.Tariffs.ToList();
        }

        public Tariff GetById(int id)
        {
            var tariff = context.Tariffs.FirstOrDefault(x => x.Id == id);
            return tariff;
        }

        public ServiceResult Post(Tariff tariff)
        {
            var result = new ServiceResult { IsSuccess = true };
            context.Tariffs.Add(tariff);
            context.SaveChanges();
            return result;
        }

        public ServiceResult Put(Tariff model)
        {
            var result = new ServiceResult { IsSuccess = false };
            var tariff = GetById(model.Id);
            if (tariff != null)
            {
                tariff.Amount = model.Amount;
                tariff.EndHour = model.EndHour;
                tariff.StartHour = model.StartHour;
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }

        public ServiceResult Delete(int id)
        {
            var result = new ServiceResult { IsSuccess = false };
            var tariff = GetById(id);
            if (tariff != null)
            {
                context.Tariffs.Remove(tariff);
                context.SaveChanges();
                result.IsSuccess = true;
            }

            return result;
        }
    }
}
