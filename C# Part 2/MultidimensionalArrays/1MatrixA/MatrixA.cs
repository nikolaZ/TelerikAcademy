using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MatrixA
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
                for (int cols = 0; cols < matrix.GetLength(0); cols++)
                {
                    for (int rows = 0; rows < matrix.GetLength(1); rows++)
                    {
                        matrix[rows,cols] = counter;
                        counter++;
                    }
                }
                Console.WriteLine("The matrix is as follows:");
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write("{0,2}"+" ", matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    

