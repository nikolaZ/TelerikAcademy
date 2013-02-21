//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Test
    {
        static void Main()
        {
            GSM cellPhone = new GSM("nokla","nnnn");
            cellPhone.Manufacturer = "Nokia";
            cellPhone.Model = "N86 8MP";
            cellPhone.Owner = "Myself and I";
            cellPhone.Price = 1234;
            cellPhone.battery.Model = "NBN86-08";
            cellPhone.battery.HoursIdle = 96;
            cellPhone.battery.HoursTalk = 24;
            //cellPhone.battery.Type = BatteryType.LiIon;
            cellPhone.display.Size = 2.5f;
            cellPhone.display.NumberOfColors = 16.5f;
            Console.WriteLine(cellPhone.Price);
        }
    }

