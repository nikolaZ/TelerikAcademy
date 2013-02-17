//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class StringMaxChar
    {
        static void Main()
        {
            string input = "123456789123456789";
            Padding(input);
        }
        static void Padding(string text)
        {
            text=text.PadRight(20, '*');
            Console.WriteLine(text);
        }
    }

