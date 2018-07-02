using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMS_Project.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public byte VehicleTypeId { get; set; }

        [Required(ErrorMessage = "Vehicle Make is required.")]
        public short VehicleMakeId { get; set; }

        [Required(ErrorMessage = "Vehicle Model is required.")]
        public short VehicleModelId { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "{0} is required.")]
        public double Price { get; set; }
    }
}