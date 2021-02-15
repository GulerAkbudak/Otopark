using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Service
{
    public interface ISellService
    {
        List<Sell> Get();
        Sell Get(int id);
        ServiceResult Post(Sell sell);        
    }
    public class SellService: ISellService
    {
        private readonly CarParkDbContext context;

        private readonly Tariff tariff;
        public SellService(CarParkDbContext context)
        {
            this.context = context;                
        }

        public List<Sell> Get()
        {
            throw new NotImplementedException();
        }

        public Sell Get(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Post(Sell sell)
        {
            throw new NotImplementedException();
        }
    }
}
