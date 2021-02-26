using Otopark.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data.Models
{
    public class UserProfileModel
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? BirthDate { get; set; }

    }
}
