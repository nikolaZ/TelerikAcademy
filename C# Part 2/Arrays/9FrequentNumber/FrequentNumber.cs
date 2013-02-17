//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int maxRepeat = 0;
        int position = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            int counter = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i]==array[j])
                {
                    counter++;
                    if (counter>maxRepeat)
                    {
                        maxRepeat = counter;
                        position = i;
                    }
                }
            }
        }
        Console.WriteLine("{0} repeats {1} times", array[position], maxRepeat);
    }
}

