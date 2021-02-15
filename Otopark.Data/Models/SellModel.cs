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

        public string ParkingSpaces { get; set; }

        public decimal Time { get; set; }

        public decimal Amount { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime ExitDate { get; set; }
    }
}
