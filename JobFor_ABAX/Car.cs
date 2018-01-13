using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFor_ABAX
{
    //car(car 1) with licence plate NF123456, 147 kW engine power, maximal speed of 200 km/h, green colour and type of personal vehicle
   public class Car
    {
        public string Licence { get; set; }

        [MyAttr("名称", "kw")]
        public int EnginePower { get; set; }


        [MyAttr("名称", "km/h")]
        public int MaxSpeed { get; set; }


        public string Color { get; set; }
        public string CarType { get; set; }


        public void Drive()
        {
            Console.WriteLine($"Car {Licence} Drvie................");


        }
    }
}
