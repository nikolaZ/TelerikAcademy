﻿//Write a program that prints to the console which day of the week is today. Use System.DateTime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DayOfWeek
    {
        static void Main()
        {
            DateTime dayOfWeek=DateTime.Now;
            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }

