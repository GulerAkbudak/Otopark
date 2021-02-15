using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otopark.Data.Entities
{
    public class Brand
    {
        public Brand()
        {
            Series = new List<Serie>();
        }
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string BrandName { get; set; }

        public List<Serie> Series { get; set; }       
    }
}
