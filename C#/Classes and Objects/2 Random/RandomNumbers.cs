﻿//Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RandomNumbers
    {
        static void Main()
        {
            Random rand=new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ",rand.Next(100,200));
            }
            Console.WriteLine();

        }
    }

