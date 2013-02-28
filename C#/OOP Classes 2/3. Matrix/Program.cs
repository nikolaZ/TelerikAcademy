using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> p = new Matrix<int>(4, 4);
            Console.WriteLine(p.ToString());
            int[,] test1 = { { 1,0,-2 }, { 0,3,-1 } };
            int[,] test2 = { { 1,3,9 }, { -2,-1,11} };

            Matrix<int> A = new Matrix<int>(test1);
            Matrix<int> B = new Matrix<int>(test2);
            Console.WriteLine(A);
            Console.WriteLine(B);

            Console.WriteLine(A+B);
            Console.WriteLine(A-B);

            int[,] test3 = { { 1, 0, -2 }, { 0, 3, -1 } };
            int[,] test4 = { { 0, 3 }, { -2, -1},{0,4} };

            Matrix<int> C = new Matrix<int>(test3);
            Matrix<int> D = new Matrix<int>(test4);
            Console.WriteLine(C*D);
            if (B)
            {
                Console.WriteLine("true!");
            }
            else
            {
                Console.WriteLine("false!");
            }
        }
    }