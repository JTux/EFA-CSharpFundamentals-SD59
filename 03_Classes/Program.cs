using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Civic";
            firstVehicle.Mileage = 12345.67d;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine($"I own a {firstVehicle.Make} {firstVehicle.Model} and it has {firstVehicle.Mileage} miles on it.");

            Console.ReadLine();
        }
    }
}
