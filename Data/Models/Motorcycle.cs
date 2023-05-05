using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Define the Motorcycle class that implements the IVehicle interface and provides a specific implementation of the Drive method.
    public class Motorcycle : IVehicle
    {
        public string Manufacturer { get; }
        public string Model { get; }
        public int Year { get; }

        public Motorcycle(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public void Drive()
        {
            Console.WriteLine("Riding the motorcycle!");
        }
    }
}
