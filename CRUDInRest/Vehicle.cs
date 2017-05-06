using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDInRest
{
    public class Vehicle
    {
        public int ID { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}