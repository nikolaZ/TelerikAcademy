//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints
//the biggest of them using the method GetMax().
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class GetMaxInt
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            GetMax(first, second);
            Console.WriteLine("Biggest Number: {0}",GetMax(third, GetMax(first, second)));
        }
        static int GetMax(int firstValue,int secondValue)
        {
            int max;
            max = firstValue;
            if (secondValue>firstValue)
            {
                max = secondValue;
            }
            return max;
        }
    }

