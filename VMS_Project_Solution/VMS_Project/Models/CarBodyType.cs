using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VMS_Project.Models
{
    public class CarBodyType
    {
        [Key]
        public byte BodyTypeId { get; set; }

        [StringLength(50)]
        [Display(Name ="Body Type")]
        [Required(ErrorMessage = "{0} is required.")]
        public string BodyTypeName { get; set; }
    }
}