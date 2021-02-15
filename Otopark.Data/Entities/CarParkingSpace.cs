using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otopark.Data.Entities
{
    public class CarParkingSpace
    {       
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string ParkingSpaces { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
