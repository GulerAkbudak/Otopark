using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otopark.Data.Models;

namespace Otopark.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        public string Plaque { get; set; }

        [Column(TypeName = "varchar")]
        public string NameSurname { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Telephone { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Year { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Color { get; set; }

        [Column(TypeName = "varchar")]
        public string Comment { get; set; }

        public int BrandId { get; set; }

        public int SerieId { get; set; }

        public int? CarParkingSpaceId { get; set; }

        public DateTime? EntryDate { get; set; }

        public bool Deleted { get; set; }

        [JsonIgnore]
        public virtual CarParkingSpace CarParkingSpaces { get; set; }
       
        [JsonIgnore]
        public virtual Brand Brand { get; set; }
       
        [JsonIgnore]
        public virtual Serie Serie { get; set; }

    }
}
