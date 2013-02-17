//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Variations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[k];
        Variation(array, n,k);
    }
    static void Variation(int[] variations,int n,int count,int index=0)
    {
        if (index==variations.Length)
        {
            Print(variations,count);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                variations[index] = i;
                Variation(variations,n,count,index+1);
            }
        }
    }
    static void Print(int[] arr,int ka)
    {
        for (int i = 0; i < 1; i++)
        {
            Console.Write("{ ");
            for (int j = 0; j < ka; j++)
            {
                Console.Write(arr[j]+1+" ");
            }
            Console.WriteLine("}");
        }
    }

}
