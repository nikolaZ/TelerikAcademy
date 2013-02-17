﻿//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//        Example: The target substring is "in". The text is as follows:
//We are living in an yellow submarine. We don't have anything else.
//Inside the submarine is very tight. So we are drinking all the day.
//We will move out of it in 5 days.
//    The result is: 9.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SubstringCount
    {
        static void Main()
        {
            string text = "We are living In an yellow submarine.We don't have anything else.Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
            string search = "in";
            text = text.ToLower();
            int index = 0;
            int counter = 0;
            while (text.IndexOf(search,index)>0)
            {
                counter++;
                index = text.IndexOf(search, index) + 1;
            }
            Console.WriteLine(counter);
        }

    }

