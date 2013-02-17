using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1MatrixB
{
    class MatrixB
    {
        static void Main()
        {
            int n =5;
            int[,] matrix = new int[n, n];
            int counter = 1;
            for (int cols = 0; cols < n; cols++)
            {
          
                    for (int rows = 0; rows < n; rows++)
                    {
                        matrix[rows, cols] = counter++;
                    }
               
                    cols++;
                    if (cols>=n)
                    {
                        break;
                    }
                    for (int rows = n-1 ; rows >= 0; rows--)
                    {
                        matrix[rows, cols] = counter++;
                    }
               
            }
            Console.WriteLine("The matrix is as follows:");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}" + " ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
