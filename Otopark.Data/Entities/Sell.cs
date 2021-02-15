using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otopark.Data.Entities
{
    public class Sell
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int CarParkingSpaceId { get; set; }

        public decimal Time { get; set; }

        public decimal Amount { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime ExitDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CarParkingSpace CarParkingSpace { get; set; }

    }
}
