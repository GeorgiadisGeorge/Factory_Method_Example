using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example.FactoryMethodInterafaces
{
    // Define the IVehicleFactory interface with a CreateVehicle method.
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}
