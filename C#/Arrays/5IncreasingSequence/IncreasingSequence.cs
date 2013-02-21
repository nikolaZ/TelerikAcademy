//Write a program that finds the maximal increasing sequence in an array.
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IncreasingSequence
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        int count = 1;
        int counter = 1;
        int safe = 0;
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j]+1 == array[j + 1])
            {
                count++;
                    safe = array[j];
                counter = count;
            }
            else
            {
                count = 1;
            }
        }
        for (int i = 0; i < counter; i++)
        {
            Console.Write(safe -1+ " ");
            safe++;
        }
    }
}


