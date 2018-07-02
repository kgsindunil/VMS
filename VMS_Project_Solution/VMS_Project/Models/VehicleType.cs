using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMS_Project.Models
{
    public class VehicleType
    {
        [Key]
        public byte VehicleTypeId { get; set; }

        [Required(ErrorMessage = "Vehicle Type Name is required!")]
        [StringLength(100)]
        [Display(Name = "Vehicle Type")]
        public string VehicleTypeName { get; set; }
    }
}