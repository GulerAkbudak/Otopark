using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otopark.Data.Entities
{
    public class Tariff
    {
        public int Id { get; set; }

        public int StartHour { get; set; }

        public int EndHour { get; set; }

        public decimal Amount { get; set; }
    }
}
