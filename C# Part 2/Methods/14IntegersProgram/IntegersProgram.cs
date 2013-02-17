//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class IntegersProgram
    {
        static void Main()
        {
            Print(Max(6, 4, 3, 2, 1));
            Print(Min(6, 4, 3, 2, 1));
            Print(Average(6, 4, 3, 2, 1,3));
            Print(Sum(6, 4, 3, 2, 1, 3));
            Print(Product(6, 4, 3, 2, 1, 3));
        }
        static int Max(params int[] sequence)
        {
            Console.Write("Max:");
            int max = int.MinValue;
            int length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                if (sequence[i] > max)
                {
                    max = sequence[i];
                }
            }
            return max;
        }
        static int Min(params int[] sequence)
        {
            Console.Write("Min:");
            int min = int.MaxValue;
            int length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                if (sequence[i] < min)
                {
                    min = sequence[i];
                }
            }
            return min;
        }
        static decimal Average(params int[] sequence)
        {
            Console.Write("Avg:");
            decimal average=0;
            int counter = sequence.GetLength(0);
            int length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                average += sequence[i];
            }
            average /= length;
            return average;
        }
        static long Sum(params int[] sequence)
        {
            Console.Write("Sum:");
            long sum = 0;
            int length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                sum += sequence[i];
            }
            return sum;
        }
        static BigInteger Product(params int[] sequence)
        {
            Console.Write("Product:");
            BigInteger product = 1;
            int length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                product*= sequence[i];
            }
            return product;
        }
        static void Print(object printer)
        {
            Console.WriteLine("{0:F6}",printer);
        }

    }

