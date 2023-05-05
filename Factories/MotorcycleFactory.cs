using Factory_Method_Example.FactoryMethodInterafaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example.InterfaceImplementations
{
    // Define the MotorcycleFactory class which implements the IVehicleFactory interface.
    public class MotorcycleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Motorcycle("Harley-Davidson", "Chopper", 1970);
        }
    }
}
