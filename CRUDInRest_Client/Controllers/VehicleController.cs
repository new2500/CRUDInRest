using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDInRest_Client.Models;
using CRUDInRest_Client.ViewModels;

namespace CRUDInRest_Client.Controllers
{
    public class VehicleController : Controller
    {

        public ActionResult Index()
        {
            VehicleServiceClient vsc = new VehicleServiceClient();
            ViewBag.listVehicles = vsc.getall();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(VehicleViewModel vvm)
        {
            VehicleServiceClient vsc = new VehicleServiceClient();
            vsc.create(vvm.Vehicle);
            return RedirectToAction("Index");
        }

        
        public ActionResult Delete(string id)
        {
            VehicleServiceClient vsc = new VehicleServiceClient();
            vsc.delete(vsc.get(id));
            return RedirectToAction("Index");
            
        }
    }
}