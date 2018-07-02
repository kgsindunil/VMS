using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMS_Project.Models
{
    public class Car : Vehicle
    {
        [Display(Name = "No. Of Wheels")]
        [Required(ErrorMessage = "{0} is required.")]
        [Range(2, 20)]
        public byte NoOfWheels { get; set; }

        [Display(Name = "No. Of Doors")]
        [Required(ErrorMessage = "{0} is required.")]
        [Range(2, 10)]
        public byte NoOfDoors { get; set; }

        [Display(Name = "No. Of Seats")]
        [Required(ErrorMessage = "{0} is required.")]
        [Range(2, 20)]
        public byte NoOfSeats { get; set; }

        public byte BodyTypeId { get; set; }
    }
}