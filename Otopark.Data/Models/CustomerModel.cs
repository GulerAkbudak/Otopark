using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otopark.Data.Entities;

namespace Otopark.Data.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int SerieId { get; set; }
        public string NameSurname { get; set; }
        public string Plaque { get; set; }
        public string SerieName { get; set; }
        public string BrandName { get; set; }
        public string ParkingSpaces { get; set; }
        public string Color { get; set; }
        public string Comment { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Telephone { get; set; }
        public string Year { get; set; }
    }
}
