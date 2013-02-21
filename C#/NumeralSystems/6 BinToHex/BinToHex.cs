//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToHex
{
    static void Main()
    {
        Console.Write("Enter binary number:");
        string number = Console.ReadLine();
        FourByFour(number);
    }
    static void ConvertBinToHex(string p)
    {
        Console.Write("Number in hex:");
        int[] arr = new int[p.Length];
        int sum = 0;
        for (int start = 0; start < p.Length; start+=4)
        {
            for (int i = start; i < 4 + start; i++)
            {
                arr[i] = p[i] - '0';
            }
            for (int i = start, powerOfBase = 8; i < arr.Length; i++, powerOfBase /= 2)
            {
                sum += arr[i] * powerOfBase;
                
            }
            if (sum > 9)
            {
                Console.Write((char)(sum + 55));
            }
            else
            {
                Console.Write(sum);
            }
            sum = 0;
        }
        Console.WriteLine();
    }
  
    static void FourByFour(string number)
    {
        string addZeros = string.Empty;
        string result = string.Empty;
        if (number.Length % 4 != 0)
        {
            number = addZeros.PadLeft(4 - (number.Length % 4), '0') + number;
        }
        result = number;
        ConvertBinToHex(result);
    }
}


