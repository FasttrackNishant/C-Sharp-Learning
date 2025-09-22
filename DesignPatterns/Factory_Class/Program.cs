using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Class
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userInput = "BIKE";

            IVehicle Type = VehicleFactory.GetVehicle(userInput);

            Console.WriteLine($"{Type.VehicleType()}");
            Console.WriteLine($"{Type.NumberOfWheels()}");
        }
    }
}