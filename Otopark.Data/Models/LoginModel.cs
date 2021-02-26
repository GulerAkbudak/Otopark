using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data.Models
{
    public class LoginModel
    {
       
        [Required(ErrorMessage = "Email zorunludur")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email formatı uygun değil.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "Email zorunludur")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email formatı uygun değil.")]
        public string Email { get; set; }
    }
}
