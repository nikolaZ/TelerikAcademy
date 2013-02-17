//Write a method that reverses the digits of given decimal number. Example: 256  652
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReversedNumber
    {
        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            ReverseNumber(number);
        }
        static void ReverseNumber(decimal number)
        {
            string digits = number.ToString();
            char[] chars = new char[digits.Length];
            chars = digits.ToCharArray();
            Array.Reverse(chars);
            string reversed=new string(chars);     //This way later you could parse the string to decimal and use the reversed number.
            decimal result = decimal.Parse(reversed);
            Console.WriteLine(result);
        }
    }

