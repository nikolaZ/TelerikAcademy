using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MatrixC
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
            int row = n-1;
            int col = 0;
            for (int diagonal = 0; diagonal < 2*n-1; diagonal++)
            {
                row -= diagonal;
                if (row<0)
                {
                    row =0;
                }
                while (row <= n - 1 && col <= n - 1)
                {


                  
                    matrix[row, col] = counter;
                    counter++;
                    row++;
                    col++;
                }
                if (row>n-1||col>n-1)
                {
                    if (col<row)
                    {
                        col = 0;
                    }
                    else
                    {
                        col = (col-row)+1;
                    }
                   
                    row--;
  
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

