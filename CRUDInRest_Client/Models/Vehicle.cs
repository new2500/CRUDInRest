using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CRUDInRest_Client.Models
{
    public class Vehicle
    {
        [Display(Name ="ID")]
        public int ID { get; set; }
        [Display(Name = "Year")]
        public int Year { get; set; }
        [Display(Name = "Make")]
        public string Make { get; set; }
        [Display(Name = "Model")]
        public string Model { get; set; }
    }
}