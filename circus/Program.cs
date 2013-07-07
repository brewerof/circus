using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using circus.model;

namespace circus
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = VehicleFactory.Create("2101");
        }
    }
}
