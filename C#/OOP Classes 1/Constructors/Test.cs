//Define several constructors for the defined classes that take different sets of arguments
// (the full information for the class or part of it). 
//Assume that model and manufacturer are mandatory (the others are optional).
// All unknown data fill with null.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Test
    {
        static void Main()
        {
            Display testDisplay = new Display(14, 16.5f);
            Battery testBattery = new Battery("test");
            GSM myPhone = new GSM("test", "test", "Owner",1234, testBattery, testDisplay);
            Console.WriteLine(myPhone.display.Size);
        }
    }

