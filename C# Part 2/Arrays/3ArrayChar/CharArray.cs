//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CharArray
    {
        static void Main()
        {
            Console.Write("Number of elements of The Arrays = ");
            int size1 = int.Parse(Console.ReadLine());
            char[] array1 = new char[size1];
            Console.WriteLine("Fill #1 Array: ");
            // Filing the #1 array
            for (int i = 0; i < size1; i++)
            {
                Console.Write("arr[{0}] = ", i);
                array1[i] = char.Parse(Console.ReadLine());
            }
            int[] array2 = new int[size1];
            Console.WriteLine("Fill #2 Array: ");
            // Filing the #2 array
            for (int j = 0; j < size1; j++)
            {
                Console.Write("arr[{0}] = ", j);
                array2[j] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size1; i++)
            {
                if (array1[i] == array2[i])
                {
                    Console.WriteLine("elements[{0}] are equal : {1}={1}", i, array1[i]);
                }
                else
                {
                    Console.WriteLine("elements[{0}] are not equal : {1}!={1}", i, array1[i]);
                }
            }
        }
    }

