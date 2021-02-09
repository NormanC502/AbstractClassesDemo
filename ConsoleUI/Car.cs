using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car:Vehicle
    {

        public bool HasTrunk { get; set; } = true || false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is a great car to drive!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("You can drive this car virtually and feel how great it is!");
        }
    }
}
