using Factory_Method_Example.FactoryMethodInterafaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example.InterfaceImplementations
{
    // Define the CarFactory class which implements the IVehicleFactory interface.
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car("Toyota", "Supra", 1998);
        }
    }
}
