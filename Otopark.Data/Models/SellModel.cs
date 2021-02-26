using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data.Models
{
    public class SellModel
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public string Plaque { get; set; }
        public string NameSurname { get; set; }

        public int? CarParkingSpaceId { get; set; }

        public string ParkingSpaces { get; set; }
        public double Hour { get; set; }
        public string Telephone{ get; set; }
        public string BrandName{ get; set; }
        public string SerieName{ get; set; }
        public string Color{ get; set; }
        public string Year { get; set; }
        public string Time { get; set; }

        public decimal Amount { get; set; }

        public string EntryDate { get; set; }

        public string ExitDate { get; set; }
    }
}
