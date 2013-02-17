//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MaxElementInPortion
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 0, -7, 8, 13, 9, -99, 88, 66, 4, 5 };
            int index = 3;
            int portionLength = 4;
            int max = int.MinValue;
            int maxIndex = 0;
            MaximalElement(array, index, portionLength,out maxIndex,out max);
            Console.WriteLine(max);
            Printer(Descending(array));
            Printer(Ascending(array));
        }
        static void MaximalElement(int[] array, int index, int portionLen,out int maxIndex,out int maxElement)
        {
             maxElement = int.MinValue;
             maxIndex = 0;
            for (int i = index; i < index + portionLen; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    maxIndex = i;
                }
            }          
        }
        static int[] Descending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int elementMax = int.MinValue;
                int index = 0;
                int temp = 0;
                MaximalElement(array, i, array.Length - i,out index,out elementMax );
                temp = array[i];
                array[i] = elementMax;
                array[index] = temp;
            }
            return array;
        }
        static int[] Ascending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int elementMax = int.MinValue;
                int index = 0;
                int temp = 0;
                MaximalElement(array, 0, array.Length -i, out index, out elementMax);
                temp = array[array.Length-i-1];
                array[array.Length - i-1] = elementMax;
                array[index] = temp;
            }
            return array;
        }
        static void Printer(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine();
        }
    }

