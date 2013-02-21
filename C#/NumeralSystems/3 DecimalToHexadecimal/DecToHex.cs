//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecToHex
{
    static void Main()
    {
        Print(ConvertDecimalToHex());
    }
    static List<int> ConvertDecimalToHex()
    {
        Console.Write("Number in decimal:");
        int number = int.Parse(Console.ReadLine());
        int baseOfSystem = 16;
        int remainder;
        List<int> binaryNumber = new List<int>();
        if (number == 0)
        {
            binaryNumber.Add(number);
        }
        while (number != 0)
        {
            remainder = number % baseOfSystem;
            binaryNumber.Add(remainder);
            number /= baseOfSystem;
        }
        return binaryNumber;
    }
    static void Print(List<int> list)
    {
        Console.Write("Number in hexadecimal:");
        list.Reverse();
        foreach (var element in list)
        {
            if (element > 9)
            {
                Console.Write((char)(element + 55));
            }
            else
            {
                Console.Write(element);
            }
        }
        Console.WriteLine();
    }
}

