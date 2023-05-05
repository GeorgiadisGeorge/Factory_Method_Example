using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Define the IVehicle interface with three properties and a Drive method.
    public interface IVehicle
    {
        string Manufacturer { get; }
        string Model { get; }
        int Year { get; }
        void Drive();
    }
}
