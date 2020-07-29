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
            // New up my Vehicle Instance
            Vehicle firstVehicle = new Vehicle();

            // Setting Make property in my firstVehicle instance
            firstVehicle.Make = "Honda";
            // Getting my Make property from firstVehicle and writing to the Console
            Console.WriteLine(firstVehicle.Make);
            
            // Setting the rest of the properties
            firstVehicle.Model = "Civic";
            firstVehicle.Mileage = 12345.67d;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            // Writing a string by getting all of our property values
            Console.WriteLine($"I own a {firstVehicle.Make} {firstVehicle.Model} and it has {firstVehicle.Mileage} miles on it.");

            Vehicle car = new Vehicle("Toyota", "Corolla", 213000, VehicleType.Car);
            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 3000000, VehicleType.Spaceship);

            Console.WriteLine(rocket.Model);

            Person josh = new Person();
            josh.FirstName = "Joshua";
            josh.LastName = "Tucker";
            Console.WriteLine(josh.FullName);

            josh.FirstName = "Casey";
            josh.LastName = "Wilson";
            Console.WriteLine(josh.FullName);

            josh.DateOfBirth = new DateTime(1991, 9, 11);
            Console.WriteLine(josh.Age);

            Console.ReadLine();
        }
    }
}
