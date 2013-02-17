//Write a program that finds the index of given element in a sorted array of integers
//by using the binary search algorithm (find it in Wikipedia).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinarySearch
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7,8,9,10 };
            int target = 10;
            Array.Sort(array);
            int middle = 0;
            int leftSide = 0;
            int rightSide = array.Length-1;
            for (int i = 0; i < array.Length; i++)
            {
                middle = (rightSide+leftSide) / 2;
                if (array[middle] == target)
                {
                    Console.WriteLine(middle);
                    break;
                }
                if (target>array[middle])
                {
                    leftSide=middle+1;
                }
                if (target<array[middle])
                {
                    rightSide=middle-1;
                }
            }
           

        }
    }

