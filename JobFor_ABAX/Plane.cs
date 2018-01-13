using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobFor_ABAX
{
    //a plane with registration LN1234, 1000 kW engine power, 30m wingspan, 2t load capacity and 10t net weight, flying class of jet plane
    public class Plane
    {
        
        public string Registration { get; set; }

        [MyAttr("名称", "kw")]
        public int EnginePower { get; set; }

        [MyAttr("名称", "m")]
        public string Wingspan { get; set; }

        [MyAttr("名称", "t")]
        public string loadCapacity { get; set; }

        [MyAttr("名称", "t")]
        public string NetWeight { get; set; }
        public string FlyClass { get; set; }

        public void Fly()
        {
            Console.WriteLine($"Plane {Registration} Fly................");
        }



    }
}
