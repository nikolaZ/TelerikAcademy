using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MatrixD
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int rotations = n / 2+n%2;
            int counter = 1;
            int row = 0;
            int col = 0;
            for (int i = 0; i < rotations; n--,i++)
            {

                col = (n - n) + i;
                row = (n - n) + i;
                while (row < n)
                {
                    matrix[row, col] = counter;
                    counter++;
                    row++;
                }
                row = n - 1;
                col++;
                while (col < n)
                {
                    matrix[row, col] = counter;
                    counter++;
                    col++;
                }

                col = n - 1;
                row--;
                while (row >= (n-n)+i)
                {
                    matrix[row, col] = counter;
                    counter++;
                    row--;
                }
                row = (n-n)+i;
                col--;
                while (col > (n - n) + i)
                {
                    matrix[row, col] = counter;
                    counter++;
                    col--;
                }
            }
            Console.WriteLine("The matrix is as follows:");
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0,3}" + " ", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }

