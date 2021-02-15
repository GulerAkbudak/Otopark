using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data.Entities
{
    public class Serie
    {

        public int Id { get; set; }

        public int BrandId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string SerieName { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }


    }
}
