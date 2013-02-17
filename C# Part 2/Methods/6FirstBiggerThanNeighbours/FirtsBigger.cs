//Write a method that returns the index of the first element in array that is bigger than its neighbors, 
//or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FirtsBigger
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 11, 12 };
            Console.WriteLine(BiggerThanTwoNeighbours(array));
        }
        static int BiggerThanTwoNeighbours(int[] arr)
        {
            for (int index = 1; index < arr.Length - 2; index++)
            {
                if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
                {
                    return index;
                }
            }
            return -1;
        }
    }

