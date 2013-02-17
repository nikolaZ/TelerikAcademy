//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sorting
{
    static void Main()
    {
        int[] array = { 3, 1, 5, 9, 2, 2, 4, 7, 6 };
        int smallest = int.MaxValue;
        int position = int.MinValue;
        for (int j = 0; j < array.Length - 1; j++)
        {
            for (int i = j; i < array.Length; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                    position = i;
                }
            }
            array[position] = array[j];
            array[j] = smallest;
            smallest = int.MaxValue;
        }
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

