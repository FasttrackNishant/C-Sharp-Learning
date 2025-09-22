using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Class
{
    public interface IVehicle
    {
        string VehicleType();
        int NumberOfWheels();
    }
}