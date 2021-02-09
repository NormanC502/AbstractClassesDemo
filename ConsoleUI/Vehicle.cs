using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {                   // Abstract class are just rules that the other classes that inherit from this class must have and use.

        public int Year { get; set; } = 2021;  //Default
        public string Make { get; set; } = "Honda"; // Default
        public string Model { get; set; } = "Civic";  // Default

        public abstract void DriveAbstract(); // Stubbed out no implementation (can be overwritten) with override

        public virtual void DriveVirtual() //Virtual method can be called later (can be overwritten) with override
        {
            Console.WriteLine();
        }



        
        
    }    
}
