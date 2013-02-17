//Write a program that reads a text file containing a square matrix of numbers
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class MatrixFile
{
    static void Main()
    {

        Platform(GetMatrix());
    }
    static int[,] GetMatrix()
    {
        StreamReader input = new StreamReader(@"C:\txt.txt");
        using (input)
        {
            int n = int.Parse(input.ReadLine());
            int[,] matrix = new int[n, n];
            for (int rows = 0; rows < n; rows++)
            {
                string numbers = input.ReadLine();
                string[] array = numbers.Split();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = int.Parse(array[cols]);
                }
            }
            return matrix;
        }
    }
    static void Platform(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;
        int sum;
        for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                sum = matrix[rows, cols] + matrix[rows + 1, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    startCol = cols;
                    startRow = rows;
                }
            }
        }
        Print(matrix, startCol, startRow, bestSum);
    }
    static void Print(int[,] array, int start, int end, int sum)
    {
        StreamWriter output = new StreamWriter(@"C:\txt.txt");
        using (output)
        {
            output.WriteLine(sum);
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    output.Write(array[end + x, start + y] + " ");
                }
                output.WriteLine();
            }
        }
    }
}

