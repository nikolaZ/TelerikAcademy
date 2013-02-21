//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.
//BinSearch() finds the largest number in the array which is ≤ K. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestNumber
{
    static void Main()
    {
        int[,] matrix = new int[,]{
                {2,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15},
                {16,27,36,46,25}};
        int k = 1;
        Search(ArrayPart(matrix), k);
    }
    static List<int> ArrayPart(int[,] array)
    {
        List<int> list = new List<int>();
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            for (int cols = 0; cols < array.GetLength(1); cols++)
            {
                list.Add(array[rows, cols]);
            }
        }
        return list;
    }
    static void Search(List<int> lists,int k)
    {
        int[]arr=lists.ToArray();
        Array.Sort(arr);
        int index = Array.BinarySearch(arr, k);
        if (index < -1)
        {
            Console.WriteLine(arr[~index - 1]);
        }
        else if (index >= 0)
        {
                Console.WriteLine(arr[index]);
        }
        else if (~index == 0)
        {
            Console.WriteLine("no");
        }

    }
}


