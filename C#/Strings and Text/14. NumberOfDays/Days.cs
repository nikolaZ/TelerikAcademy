//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

    class Days
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.mm.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.mm.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine((secondDate-firstDate).TotalDays);
        }
    }

