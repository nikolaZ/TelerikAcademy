//Write a program that finds in given array of integers
//a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SumSequence
    {
        static void Main()
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int s = 12;
            int sum = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                sum = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i]==s)
                    {
                        Console.WriteLine(array[i]);
                    }
                    sum +=array[j + 1];
                    if (sum==s)
                    {
                        for (int p = 0; p <= j+1-i; p++)
                        {
                            Console.Write(array[i]+" ");
                            i++;
                            j++;
                        }
                    }
                    if (sum>s)
                    {
                        break;
                    }
                }
            }
        }
    }

