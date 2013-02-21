//Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
//Ensure all fields hold correct data at any given time.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Test
    {
        static void Main()
        {
            GSM cellPhone = new GSM("ssss", "aaaa","jj");
            cellPhone.Manufacturer = "Nokia";
            cellPhone.Model = "N86 8MP";
            cellPhone.Owner = "Myself and I";
            cellPhone.Price = 1234;
            cellPhone.battery.Model = "NBN86-08";
            cellPhone.battery.HoursIdle = 96;
            cellPhone.battery.HoursTalk = 24;
            cellPhone.display.Size = 2.5f;
            cellPhone.battery.Type = BatteryType.NiCd;
            cellPhone.display.NumberOfColors = 16.5f;
            Display testDisplay = new Display(14, 16.5f);
            GSM myPhone = new GSM("test", "test", "Owner", 1234);
            Console.WriteLine(cellPhone);
        }
    }

