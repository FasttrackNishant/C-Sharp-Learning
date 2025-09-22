using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Class
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string objType)
        {
            IVehicle objectType = null;

            if (objType.ToLower().Equals("bike"))
            {
                objectType = new Bike();
            }
            else if (objType.ToLower().Equals("car"))
            {
                objectType = new Car();
            }

            return objectType;

        }
    }
}