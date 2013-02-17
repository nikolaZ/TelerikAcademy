//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class StringReverse
    {
        static void Main()
        {
            string word = Console.ReadLine();
            char[] wordReverse=word.ToCharArray();
            Array.Reverse(wordReverse);
            string result = new string(wordReverse);
            Console.WriteLine(result);
        }
    }

