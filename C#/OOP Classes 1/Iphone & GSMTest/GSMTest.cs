//Write a class GSMTest to test the GSM class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class GSMTest
    {
        static void Main()
        {
            GSM[] tests = new GSM[3];
            GSM cellPhone1 = new GSM("Desire X", "HTC", "HTC Store", 499.99M);
            tests[0] = cellPhone1;
            GSM cellPhone2 = new GSM("Lumia 810","Nokia");
            cellPhone2.Price = 499.99M;
            cellPhone2.Owner = "OVI Store";
            cellPhone2.battery.Type = BatteryType.Li_Ion;
            tests[1] = cellPhone2;
            GSM cellPhone3 = GSM.iPhone;
            tests[2] = cellPhone3;
            foreach (var item in tests)
            {
                Console.WriteLine(item);
            }
        }

    }

