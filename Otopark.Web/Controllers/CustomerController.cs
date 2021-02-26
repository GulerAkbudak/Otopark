using Otopark.Data.Entities;
using Otopark.Data.Models;
using Otopark.Service;
using Otopark.Web.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Otopark.Web.Controllers
{
    [OtoparkAuthorize]
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("List")]
        public ActionResult List()
        {
            var list = customerService.Get();
            return Json(list, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        [Route("GetEmptyPark")]
        public ActionResult GetEmptyPark()
        {
            var data = customerService.GetEmptyPark();
            return Json(data, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        [Route("Get")]
        public ActionResult Get(int id)
        {
            var list = customerService.Get(id);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateOrUpdate")]
        public ActionResult CreateOrUpdate(Customer model)
        {
            var result = new ServiceResult();
            if (model.Id == 0)
            {
                result = customerService.Post(model);
            }
            else
            {
                result = customerService.Put(model);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete(int id)
        {
            var result = customerService.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}