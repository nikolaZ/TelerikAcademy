//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinaryToDecimal
    {
        static void Main()
        {
            ConvertBinaryToDecimal();
        }
        static void ConvertBinaryToDecimal()
        {
            Console.Write("Enter binary number:");
            string number = Console.ReadLine();
            int sum=0;
            int powerOfBase=1;
            int[] arr = new int[number.Length];
            int index = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                arr[index]=number[i]-'0';
                index++;
            }
            for (int i = 0; i < arr.Length; i++,powerOfBase*=2)
            {
                sum += arr[i] * powerOfBase;
            }
            Console.WriteLine("Number in decimal:{0}",sum);
        }
    }

