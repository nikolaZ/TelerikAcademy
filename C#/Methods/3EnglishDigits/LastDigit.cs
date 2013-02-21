//Write a method that returns the last digit of given integer as an English word.
//Examples: 512  "two", 1024  "four", 12309  "nine".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LastDigit
    {
        static void Main()
        {
            int someInteger = int.Parse(Console.ReadLine());
            EnglishDigit(someInteger);
        }
        static void EnglishDigit(int number)
        {
            int digit;
            digit = number % 10;
            switch (digit)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("zero");
                    break;
            }
        }
    }

