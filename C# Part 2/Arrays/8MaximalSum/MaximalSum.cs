//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaximalSum
    {
        static void Main()
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int bestSum = -1;
            int sum = -1;
            int sequenceStart = 0;
            int sequenceEnd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = array[i];
                for (int j = i; j < array.Length-1; j++)
                {
                    sum += array[j+1];
                    if (bestSum<sum)
                    {
                        bestSum = sum;
                        sequenceStart = i;
                        sequenceEnd=j+1;
                    }
                }
            }
            if (bestSum>=0)
            {
                for (int p = sequenceStart; p <= sequenceEnd; p++)
                {
                    Console.Write(array[p] + " ");
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        Console.WriteLine("No sequence of maximal sum");
                        break;
                    }
                    if (i == array.Length - 1)
                    {
                        Console.WriteLine("All elements are negative");
                    }
                }             
            }
        }
    }

