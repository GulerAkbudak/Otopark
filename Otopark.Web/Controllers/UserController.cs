using Otopark.Data.Entities;
using Otopark.Data.Models;
using Otopark.Data.Helper;
using Otopark.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otopark.Web.Controllers
{
    public class UserController : Controller
    {
        CarParkDbContext context = new CarParkDbContext();

        private readonly IUserService userService;
        // GET: User
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Exit()
        {
            Session.Abandon();
            return RedirectToAction("Login", "User");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [Route("MyAccountEdit")]
        public ActionResult MyAccountEdit(UserProfileModel model)
        {
            var data = userService.MyAccountEdit(model);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        
        [HttpPost]
        public ActionResult ForgotPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var result = userService.ForgotPassword(model);
            }

            return View();

        }

        [HttpPost]
        [Route("Login")]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = userService.Login(model);

                if (result.IsSuccess)
                {
                    var user = (User)result.Data;
                    Session["UserId"] = user.Id;
                    Session["NameSurname"] = user.NameSurname;
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                   ViewBag.ErrorMessage= "Email ya da Şifre Hatalı!";
                }
            }
            return View(model);

        }
    }
}