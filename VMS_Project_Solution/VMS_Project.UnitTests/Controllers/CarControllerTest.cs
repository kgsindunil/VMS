using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using VMS_Project.Controllers;

namespace VMS_Project.UnitTests.Controllers
{
    [TestFixture]
    public class CarControllerTest
    {
        [Test]
        public void VehicleModelsForMake_WhenCalled_ReturResultIsNotNull()
        {
            // Arrange
            var controller = new CarController();

            // Act
            var result = controller.VehicleModelsForMake(1);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Create_WhenCalled_ReturResultIsNotNull()
        {
            // Arrange
            var controller = new CarController();

            // Act
            
            FormCollection collection = new FormCollection();
            collection.Add("VehicleTypeId", "1");
            collection.Add("VehicleMakeId", "2");
            collection.Add("VehicleModelId", "1");
            collection.Add("Price", "1256.25");
            collection.Add("NoOfWheels", "8");
            collection.Add("NoOfDoors", "6");
            collection.Add("NoOfSeats", "5");
            collection.Add("BodyTypeId", "1");

            var result = controller.Create(collection);

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}
