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
    public class ParkingSpacesController : Controller
    {
        private readonly ICarParkingSpaceService parkingSpaceService;
        private readonly ISellService sellService;
        public ParkingSpacesController(ICarParkingSpaceService parkingSpaceService, ISellService sellService)
        {
            this.parkingSpaceService = parkingSpaceService;
            this.sellService = sellService;
        }
        // GET: ParkingSpaces
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Crud()
        {
            return View();
        }
        
        [HttpGet]
        [Route("List")]
        public ActionResult List()
        {
            var list = parkingSpaceService.Get();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("Get")]
        public ActionResult Get(int id)
        {
            var list = parkingSpaceService.Get(id);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateOrUpdate")]
        public ActionResult CreateOrUpdate(CarParkingSpace model)
        {
            if (model.Id == 0)
            {
                var data = parkingSpaceService.Post(model);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var data = parkingSpaceService.Put(model);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        [Route("Delete")]
        public ActionResult Delete(int id)
        {
            var data = parkingSpaceService.Delete(id);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("ChangeStatus")]
        public ActionResult ChangeStatus(ChangeStatusModel model)
        {
            var data = parkingSpaceService.ChangeStatus(model);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("PayDetails")]
        public ActionResult PayDetails(int id)
        {
            var data = sellService.PayDetails(id);
            return Json(data, JsonRequestBehavior.AllowGet);
        }



    }
}