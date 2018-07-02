using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMS_Project.Models;

namespace VMS_Project.Controllers
{
    public class VehicleController : Controller
    {

        public ActionResult Index()
        {

            List<Car> newList = ((List<Car>)this.Session["CarListSession"]);


            List<Vehicle> _vehicleList = new List<Vehicle>();
            foreach (var item in newList)
            {
                Vehicle _Vehicle = new Vehicle
                {
                    Id = item.Id,
                    VehicleTypeId = item.VehicleTypeId,
                    VehicleMakeId = item.VehicleMakeId,
                    VehicleModelId = item.VehicleModelId,
                    Price = item.Price
                };

                _vehicleList.Add(_Vehicle);
            }            

            return View(_vehicleList);
        }


        public ActionResult Edit(Guid id)
        {
            var car = new Car();
            car = ((List<Car>)this.Session["CarListSession"]).Find(i => i.Id == id);
            return RedirectToAction("Create", "Car", car);
        }

        
    }
}