using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMS_Project.Models;
using VMS_Project.ViewModel;

namespace VMS_Project.Controllers
{
    public class CarController : Controller
    {

        public ViewResult Create(Car _car)
        {

            if (this.Session["CarListSession"] == null)
            {
                this.Session["CarListSession"] = new List<Car>();
            }
            

            var makeList = new List<VehicleMake>
            {
                new VehicleMake() { VehicleMakeId = 1, VehicleMakeName = "Toyota" },
                new VehicleMake() { VehicleMakeId = 2, VehicleMakeName = "Nissan" }
            };

            var modelList = new List<VehicleModel>
            {
                new VehicleModel() { VehicleModelId = 1, VehicleModelName = "Camry" },
                new VehicleModel() { VehicleModelId = 2, VehicleModelName = "Sunny" }
            };

            var bodytypeList = new List<CarBodyType>
            {
                new CarBodyType() { BodyTypeId = 1, BodyTypeName = "Sedan" },
                new CarBodyType() { BodyTypeId = 2, BodyTypeName = "Hatchback" }
            };

            var carViewModel = new CarViewModel()
            {
                VehicleTypeId = 1
                ,
                _VehicleMake = makeList
                ,
                _VehicleModel = modelList
                ,
                _CarBodyType = bodytypeList
            };


            if (_car.Id != Guid.Empty)
            {
                carViewModel.VehicleTypeId = _car.VehicleTypeId;
                carViewModel.VehicleMakeId = _car.VehicleMakeId;
                carViewModel.VehicleModelId = _car.VehicleModelId;
                carViewModel.BodyTypeId = _car.BodyTypeId;
                carViewModel.NoOfDoors = _car.NoOfDoors;
                carViewModel.NoOfSeats = _car.NoOfSeats;
                carViewModel.NoOfWheels = _car.NoOfWheels;
                carViewModel.Price = _car.Price;

            }

            return View("Create", carViewModel);
        }

        public JsonResult VehicleModelsForMake(short _VehicleMakeId) // its a GET, not a POST
        {
            var modelList = new List<VehicleModel>
            {
                new VehicleModel() { VehicleModelId = 1, VehicleMakeId = 1,VehicleModelName = "Camry" },
                new VehicleModel() { VehicleModelId = 2, VehicleMakeId = 2,VehicleModelName = "Sunny" }
            };

            var newModelList = modelList.FindAll(i => i.VehicleMakeId == _VehicleMakeId);

            return Json(newModelList, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View("Index");
                }

                var _car = new Car
                {
                    Id = Guid.NewGuid(),
                    VehicleTypeId = Convert.ToByte(collection["VehicleTypeId"]),
                    VehicleMakeId = Convert.ToInt16(collection["VehicleMakeId"]),
                    VehicleModelId = Convert.ToInt16(collection["VehicleModelId"]),
                    Price = Convert.ToDouble(collection["Price"]),
                    NoOfWheels = Convert.ToByte(collection["NoOfWheels"]),
                    NoOfDoors = Convert.ToByte(collection["NoOfDoors"]),
                    NoOfSeats = Convert.ToByte(collection["NoOfSeats"]),
                    BodyTypeId = Convert.ToByte(collection["BodyTypeId"])
                };

                ((List<Car>)this.Session["CarListSession"]).Add(_car);
                
                return RedirectToAction("Create", new Car());
            }
            catch
            {
                return View("Index");
            }
        }
        
    }
}
