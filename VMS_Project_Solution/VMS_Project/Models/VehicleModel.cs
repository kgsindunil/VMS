using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMS_Project.Models
{
    public class VehicleModel
    {
        [Key]
        public short VehicleModelId { get; set; }
        public short VehicleMakeId { get; set; }
        [StringLength(100)]
        [Display(Name = "Vehicle Model")]
        [Required(ErrorMessage = "{0} is required.")]
        public string VehicleModelName { get; set; }
    }
}