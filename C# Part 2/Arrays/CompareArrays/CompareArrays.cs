//Write a program that reads two arrays from the console and compares them element by element.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Number of elements of The Arrays = ");
            int size1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[size1];
            Console.WriteLine("Fill #1 Array: ");
            for (int i = 0; i < size1; i++)
            {
                Console.Write("arr[{0}] = ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }
            int size2 = size1;
            int[] array2 = new int[size2];
            Console.WriteLine("Fill #2 Array: ");
            for (int j = 0; j < size2; j++)
            {
                Console.Write("arr[{0}] = ", j);
                array2[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size1; i++)
            {
                if (array1[i]==array2[i])
                {
                    Console.WriteLine("elements[{0}] are equal : {1}={2}",i,array1[i],array2[i]);
                }
                else
                {
                    Console.WriteLine("elements[{0}] are not equal : {1}!={2}", i, array1[i], array2[i]);
                }
            }
        }
    }

