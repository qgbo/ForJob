using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFor
{
   public class Program
    {
        static void Main(string[] args)
        {

            Run();
            Console.ReadKey();

        }

        public static string Run()
        {
            try
            {
                Car car1 = new Car() { Licence = "NF123456", EnginePower = 147, MaxSpeed = 140, Color = "green", CarType = "personal vehicle" };
                Car car2 = new Car() { Licence = "NF654321", EnginePower = 150, MaxSpeed = 195, Color = "blue", CarType = "personal vehicle" };
                Plane plane = new Plane() { Registration = "ABC123", EnginePower = 1000, Wingspan = "30", loadCapacity = "2", FlyClass = "jet plane" };

                Boat boat = new Boat { Registration = "LN1234", EnginePower = 100, MaxSpeed = 30, GrossTonnage = 500 };
                Common.print(car1);
                Common.print(car2);
                Common.print(plane);




            }
            catch (Exception e)
            {
                return "Fail "+e.Message;
            }
         
            return "Success Over!";
        }
    }
}
