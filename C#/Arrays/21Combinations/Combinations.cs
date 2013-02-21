//Write a program that reads two numbers N and K and generates
//all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Combinations1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];

            Combination(array, n, k, 0);
        }
        static void Combination(int[] combinations, int n, int k, int index,int counter=0 )
        {
            if (index == combinations.Length)
            {
                Print(combinations,k);
            }
            else
            {
                for (int i = counter; i < n; i++)
                {
                    combinations[index] = i+1;
                    Combination(combinations, n, k, index + 1,i + 1);
                    
                }
            }

        }
        static void Print(int[] arr, int ka)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < ka; j++)
                {
                    Console.Write(arr[j] +" ");
                }
                Console.WriteLine("}");
            }
        }

    }

