//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class LeapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            IsLeapYear(year);
        }
        static void IsLeapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Year {0} is leap.",year);
            }
            else
            {
                Console.WriteLine("Year {0} is NOT leap.", year);       
            }
        }
    }

