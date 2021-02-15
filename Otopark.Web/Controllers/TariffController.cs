using Otopark.Data.Entities;
using Otopark.Data.Models;
using Otopark.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otopark.Web.Controllers
{
    public class TariffController : Controller
    {
        private readonly TariffService tariffService;
        public TariffController(TariffService tariffService)
        {
            this.tariffService = tariffService;
        }
        // GET: Tariff
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("List")]
        public ActionResult List()
        {
            var result = tariffService.Get();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateOrUpdate")]
        public ActionResult CreateOrUpdate(Tariff tariff)
        {
            var result = new ServiceResult();
            if(tariff.Id==0)
            { 
                result = tariffService.Post(tariff);
            }
            else
            {
                result = tariffService.Put(tariff);
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete(int id)
        {
            var result = tariffService.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}