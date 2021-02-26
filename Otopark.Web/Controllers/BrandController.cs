using Newtonsoft.Json;
using Otopark.Data.Entities;
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
    public class BrandController : Controller
    {
        private readonly IBrandService brandService;
        public BrandController(IBrandService brandService)
        {
            this.brandService = brandService;
        }

        // GET: Brand
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("List")]
        public ActionResult List()
        {
            var list = brandService.Get();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateOrUpdate")]
        public ActionResult CreateOrUpdate(Brand brand)
        {
            if (brand.Id == 0)
            {
                var result = brandService.Post(brand);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var result = brandService.Put(brand);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete(int id)
        {
            var result = brandService.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}