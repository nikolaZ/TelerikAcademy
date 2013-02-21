//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,
//battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Test
    {
        static void Main()
        {
            GSM cellPhone = new GSM();
            cellPhone.Manufacturer = "Nokia";
            cellPhone.Model = "N86 8MP";
            cellPhone.Owner = "Myself and I";
            cellPhone.Price = 1234;
            cellPhone.battery.Model = "NBN86-08";
            cellPhone.battery.HoursIdle = 96;
            cellPhone.battery.HoursTalk = 24;
            cellPhone.display.Size = 2.5f;
            cellPhone.display.NumberOfColors = 16.5f;
        }
    }

