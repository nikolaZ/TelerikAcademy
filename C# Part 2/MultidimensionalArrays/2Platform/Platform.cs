//Write a program that reads a rectangular matrix of size N x M and
//finds in it the square 3 x 3 that has maximal sum of its elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Platform
    {
        static void Main()
        {
            int[,] matrix = {
                        {1, 1, 0, 3, 2, 1},
                        {1, 1, 0, 8, 5, 6},
                        {1, 1, 0, 9, 1, 0},
                        {1, 1, 0, 9, 1, 9}};
            int bestSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;
            int sum;
            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
                {
                     sum = matrix[rows, cols] + matrix[rows + 1, cols] + matrix[rows + 2, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols + 1] + matrix[rows + 2, cols + 1] + matrix[rows, cols + 2] + matrix[rows + 1, cols + 2] + matrix[rows + 2, cols + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        startCol = cols;
                        startRow = rows;
                    }
                }
            }
            Print(matrix, startCol, startRow);
        }
        static void Print(int[,] array,int start,int end)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(array[end+x,start+y]+" ");
                }
                Console.WriteLine();
            }
        }
    }

