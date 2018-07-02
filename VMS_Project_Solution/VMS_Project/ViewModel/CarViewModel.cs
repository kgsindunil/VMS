using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VMS_Project.Models;

namespace VMS_Project.ViewModel
{
    public class CarViewModel: Car
    {
        [Display(Name = "Make")]
        public IEnumerable<VehicleMake> _VehicleMake { get; set; }

        [Display(Name = "Model")]
        public IEnumerable<VehicleModel> _VehicleModel { get; set; }

        [Display(Name = "Body Type")]
        public IEnumerable<CarBodyType> _CarBodyType { get; set; }
    }
}