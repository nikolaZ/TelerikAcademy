//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DecimalToBinary
    {
        static void Main()
        {
            Print(ConvertDecimalToBinary());
        }
        static List<int> ConvertDecimalToBinary()
        {
            Console.Write("Number in decimal:");
            int number = int.Parse(Console.ReadLine());
            int baseOfSystem=2;
            int remainder;
            List<int> binaryNumber = new List<int>();
            if (number==0)
            {
                binaryNumber.Add(number);
            }
            while (number!=0)
            {
                remainder=number % baseOfSystem;
                binaryNumber.Add(remainder);
                number /= baseOfSystem;
            }
            return binaryNumber;
        }
        static void Print(List<int> list)
        {
            Console.Write("Number in binary:");
            list.Reverse();
            foreach (var element in list)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }

