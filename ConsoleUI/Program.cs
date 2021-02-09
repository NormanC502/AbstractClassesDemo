using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Complete  -  Create an abstract class called Vehicle
             * Complete  -  The vehicle class shall have three string properties Year, Make, and Model
             * Complete  -  Set the defaults to something generic in the Vehicle class
             * Complete  -  Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Complete  -  Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Complete  -  Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Complete  -  Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Complete  -  Provide the implementations for the abstract methods
             * Complete  -  Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car Dodge = new Car() { HasTrunk = true, Make = "Dodge", Model = "Viper", Year = 2021 }; // instance of objects

            Motorcycle HarleyDavidson = new Motorcycle() { HasSideCart = false, Make = "Harley Davidson", Model = "1200", Year = 2021 }; // instance of object

            Vehicle Economy = new Car() { HasTrunk = true, Make = "Honda", Model = "Fit", Year = 2021 }; // instance of object

            Vehicle Luxury = new Car() { HasTrunk = true, Make = "Acura", Model = "RXL", Year = 20201 }; // instance of object


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(Dodge);
            vehicles.Add(HarleyDavidson);   // Adding each object to list created "vehicles"
            vehicles.Add(Economy);
            vehicles.Add(Luxury);

            foreach (var ride in vehicles)       // for each loop to iterate through list and output properties in abstract class for each list of vehicles
            {
                Console.WriteLine($"Make:   {ride.Make}   Model:    {ride.Model}    Year:    {ride.Year}");
                Console.WriteLine("\n");
               // ride.DriveAbstract(); prints for all
               // ride.DriveVirtual(); prints for all
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine($"{Dodge.Make}    {Dodge.Model}    {Dodge.Year}");
            Dodge.DriveAbstract();
            Dodge.DriveVirtual();
            Console.WriteLine("\n");

            Console.WriteLine($"{HarleyDavidson.Make}        {HarleyDavidson.Model}            {HarleyDavidson.Year}");
            HarleyDavidson.DriveAbstract();
            HarleyDavidson.DriveVirtual();



            #endregion

        }
    }
}
