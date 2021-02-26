using Otopark.Data.Entities;
using Otopark.Data.Helper;
using Otopark.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Service
{
    public interface IUserService
    {
        ServiceResult Login(LoginModel model);
        ServiceResult ForgotPassword(ForgotPasswordModel model);
        ServiceResult MyAccountEdit(UserProfileModel model);
    }
    public class UserService : IUserService
    {
        private readonly CarParkDbContext context;
        public UserService(CarParkDbContext context)
        {
            this.context = context;
        }

        public ServiceResult ForgotPassword(ForgotPasswordModel model)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Login(LoginModel model)
        {
            var result = new ServiceResult { IsSuccess = false };
            var cryptedPassword = CryptHelper.MdBes(model.Password);
            var data = context.Users.FirstOrDefault(x => x.Email == model.Email && x.Password == cryptedPassword);
            if (data != null)
            {
                result.IsSuccess = true;
                result.Data = data;
            }
            return result;
        }

        public ServiceResult MyAccountEdit(UserProfileModel model)
        {
            var result = new ServiceResult { IsSuccess = false };
            var data = context.Users.Find(model.Id);
            if (data != null)
            {
                data.NameSurname = model.NameSurname;
                data.BirthDate = model.BirthDate;
                data.Gender = model.Gender;
                context.SaveChanges();
                result.IsSuccess = true;
            }
            return result;
        }
    }
}
