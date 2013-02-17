//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CharUnicode
    {
        static void Main()
        {
            string input = "Hi!";
            Convert(input);
        }
        static void Convert(string input)
        {
            foreach (char letter in input)
            {
                Console.Write("\\u{0:X4}",(int)letter);
            }
            Console.WriteLine();
        }
    }

