//Write a method that checks if the element at given position
//in given array of integers is bigger than its two neighbors (when such exist).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class BiggerThanNeighbours
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 0, 4, 5, 6, 3, 2, 11, 9 };
            int index = 3;
            BiggerThanTwoNeighbours(array, index);

        }
        static void BiggerThanTwoNeighbours(int[] arr, int index)
        {
            if (index>0&&index<arr.Length)
            {
                if (arr[index]>arr[index-1]&&arr[index]>arr[index+1])
                {
                    Console.WriteLine("The element at position {0} -> {1} IS bigger than its two neighbours {2} and {3}", index, arr[index], arr[index-1], arr[index+1]);
                }
                else
                {
                    Console.WriteLine("The element at position {0} -> {1} is NOT bigger than its two neighbours {2} and {3}", index, arr[index], arr[index - 1], arr[index + 1]);
                }
            }
            else
            {
                Console.WriteLine("The element at position {0} -> {1} does not have two neighbours.", index, arr[index]);
            }
        }
    }

