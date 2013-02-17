using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HexToBin
    {
        static void Main()
        {
            Print(ConvertHexToBinary());
        }
        static List<int> ConvertHexToBinary()
        {
            Console.Write("Number in hex:");
            string number = Console.ReadLine();
            int baseOfSystem = 2;
            int remainder;
            List<int> binaryNumber = new List<int>();
            number = number.ToUpper();
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
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < 4; j++)                                
                {
                    remainder = arr[i] % baseOfSystem;
                    binaryNumber.Add(remainder);
                    arr[i] /= baseOfSystem;
                }                
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

