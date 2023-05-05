using Factory_Method_Example.FactoryMethodInterafaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example.InterfaceImplementations
{
    // Define the TruckFactory class which implements the IVehicleFactory interface.
    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Truck("Ford", "F-150", 2022);
        }
    }
}
