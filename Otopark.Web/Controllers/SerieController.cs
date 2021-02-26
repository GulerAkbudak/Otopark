using Newtonsoft.Json;
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
    public class SerieController : Controller
    {
        private readonly SerieService serieService;
        public SerieController(SerieService serieService)
        {
            this.serieService = serieService;
        }
        // GET: Serie
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("List")]
        public ActionResult List()
        {
            var list = serieService.Get();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetByBrandId")]
        public ActionResult GetByBrandId(int id)
        {
            var list = serieService.GetByBrandId(id);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateOrUpdate")]
        public ActionResult CreateOrUpdate(SerieModel model)
        {
            var result = new ServiceResult();
            if (model.Id == 0)
            {
                result = serieService.Post(model);
            }
            else
            {
                result = serieService.Put(model);
            }            
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete(int id)
        {
            var result = serieService.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}