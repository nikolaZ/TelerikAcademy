//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DaysHours
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            firstDate=firstDate.AddHours(6.5);
            string result = firstDate.ToString("d.MM.yyyy HH:mm:ss", new CultureInfo("bg-BG"));
            Console.WriteLine(result);
        }
    }
