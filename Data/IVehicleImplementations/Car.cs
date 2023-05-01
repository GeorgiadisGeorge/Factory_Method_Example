using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Define the Car class that implements the IVehicle interface and provides a specific implementation of the Drive method.
    public class Car : IVehicle
    {
        public string Manufacturer { get; }
        public string Model { get; }
        public int Year { get; }

        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public void Drive()
        {
            Console.WriteLine("Driving the car!");
        }
    }
}
