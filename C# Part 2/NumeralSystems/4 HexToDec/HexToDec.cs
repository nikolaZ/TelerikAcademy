//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HexToDec
    {
        static void Main()
        {
            ConvertHexToDecimal();
        }
        static void ConvertHexToDecimal()
        {
            Console.Write("Enter Hex number:");
            string number = Console.ReadLine();
            number=number.ToUpper();
            int sum = 0;
            int powerOfBase = 1;
            int[] arr = new int[number.Length];
            int index = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                arr[index] = number[i] - '0';
                if (arr[index] > 9)
                {
                    arr[index] -= 7;
                }
                index++;
            }
            for (int i = 0; i < arr.Length; i++, powerOfBase *= 16)
            {
                sum += arr[i] * powerOfBase;
            }
            Console.WriteLine("Number in decimal:{0}", sum);
        }
    }

