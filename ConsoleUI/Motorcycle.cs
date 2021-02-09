using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle:Vehicle
    {
        public bool HasSideCart { get; set; } = true || false; 

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is a thriller!"); //could have :throw new NotImplementedException();
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("In this virtual drive for Harley Davidson Hear those Pipes sing baby!!");
        }
    }
}
