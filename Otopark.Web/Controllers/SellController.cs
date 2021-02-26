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
    public class SellController : Controller
    {
        private readonly SellService sellService;

        public SellController(SellService sellService)
        {
            this.sellService = sellService;
        }

        [HttpPost]
        [Route("Pay")]
        public ActionResult Pay(SellModel model)
        {
            var data = sellService.Post(model);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}