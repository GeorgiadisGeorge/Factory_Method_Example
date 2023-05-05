using Factory_Method_Example.FactoryMethodInterafaces;
using Factory_Method_Example.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a CarFactory object and use it to create a Car object.
            IVehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.CreateVehicle();

            // Create a TruckFactory object and use it to create a Truck object.
            IVehicleFactory truckFactory = new TruckFactory();
            IVehicle truck = truckFactory.CreateVehicle();

            // Create a MotorcycleFactory object and use it to create a Motorcycle object.
            IVehicleFactory motorcycleFactory = new MotorcycleFactory();
            IVehicle motorcycle = motorcycleFactory.CreateVehicle();

            // Drive each vehicle and display its properties.
            car.Drive();
            Console.WriteLine($"Car properties: Manufacturer={car.Manufacturer}, Model={car.Model}, Year={car.Year}");

            Console.WriteLine("-----------------------------------------------------");

            truck.Drive();
            Console.WriteLine($"Truck properties: Manufacturer={truck.Manufacturer}, Model={truck.Model}, Year={truck.Year}");

            Console.WriteLine("-----------------------------------------------------");

            motorcycle.Drive();
            Console.WriteLine($"Motorcycle properties: Manufacturer={motorcycle.Manufacturer}, Model={motorcycle.Model}, Year={motorcycle.Year}");

            Console.ReadLine();
        }
    }
}
