using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMS_Project.Models
{
    public class VehicleMake
    {
        [Key]
        public short VehicleMakeId { get; set; }

        [StringLength(100)]
        [Display(Name = "Vehicle Make")]
        [Required(ErrorMessage = "{0} is required.")]
        public string VehicleMakeName { get; set; }
    }
}