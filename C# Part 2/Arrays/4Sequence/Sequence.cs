//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sequence
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int count = 1;
        int counter = 1;
        int safe = 0;
            for (int j = 0; j < array.Length-1; j++)
            {
                if (array[j] == array[j + 1])
                {
                    count++;
                    if (count>counter)
                    {
                            safe = array[j];
                    }
                    counter = count;
                }
                else
                {
                    count = 1;
                    
                }
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write(safe + " ");
            }
    }
}

