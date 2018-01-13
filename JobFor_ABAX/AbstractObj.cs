using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFor_ABAX
{
    //car(car 1) with licence plate NF123456, 147 kW engine power, maximal speed of 200 km/h, green colour and type of personal vehicle
   public class AbstractObj
    {
        
        public string Licence { get; set; }
        public int EnginePower { get; set; }
        public int MaxSpeed { get; set; }
        public string Color { get; set; }
        public string CarType { get; set; }
    }
}
