using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Matrix<T> where T:IComparable
    {
        public int Col { get; private set; }
        public int Row { get; private set; }
        public T[,] MatrixT;
        
        public Matrix():this(0,0)
        {
        }
        public Matrix(T[,] matrix)
        {
            this.MatrixT = matrix;
            Row = matrix.GetLength(0);
            Col = matrix.GetLength(1);
        }
        public Matrix(int rows, int cols)
        {
            if (rows<0 || cols<0 ){throw new ArgumentException("Matrix's dimensions must be positive");}
            this.Row = rows;
            this.Col = cols;
            this.MatrixT = new T[rows, cols];
        }
        public T this[int row, int col]
        {
            get
            {
                //if (row>0 || col>0 || col>Col || row>Row)
                //{
                //    throw new ArgumentException("Index outside the matrix");
                //}
                return MatrixT[row, col];
            }
            set 
            {
                //if (row > 0 || col > 0 || col > Col || row > Row)
                //{
                //    throw new ArgumentException("Index outside the matrix");
                //}
                MatrixT[row, col]=value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> A, Matrix<T> B)
        {
            if (A.Row != B.Row || A.Col!=B.Col)
            {
                throw new FormatException("Columns and rows of Matrix A and Matrix B must be equal");
            }
            Matrix<T> sum = new Matrix<T>(A.Row, A.Col);
            for (int i = 0; i < A.Row; i++)
            {
                for (int j = 0; j < A.Col; j++)
                {
                    sum[i, j] = (dynamic)A[i, j] + B[i, j];
                }
            }
            return sum;
        }
        public static Matrix<T> operator -(Matrix<T> A, Matrix<T> B)
        {
            if (A.Row != B.Row || A.Col != B.Col)
            {
                throw new FormatException("Columns and rows of Matrix A and Matrix B must be equal");
            }
            Matrix<T> difference = new Matrix<T>(A.Row, A.Col);
            for (int i = 0; i < A.Row; i++)
            {
                for (int j = 0; j < A.Col; j++)
                {
                    difference[i, j] = (dynamic)A[i, j] - B[i, j];
                }
            }
            return difference;
        }
        public static Matrix<T> operator *(Matrix<T> A, Matrix<T> B)
        {
            if (A.Col!=B.Row)
            {
                throw new FormatException("Columns of Matrix A and Rows of Matrix B must be equal");
            }
            Matrix<T> product = new Matrix<T>(A.Row, B.Col);
            for (int row = 0; row < product.Row; row++)
            {
                for (int col = 0; col < product.Col; col++)
                {
                    for (int i = 0; i < A.Col; i++)
                    {
                        product[row, col] += (dynamic)A[row, i] * B[i, col];
                    }
                }
            }
            return product;
        }
        public static bool operator true(Matrix<T> A)
        {
            for (int i = 0; i < A.Row; i++)
            {
                for (int j = 0; j < A.Col; j++)
                {
                    if ((dynamic)A[i,j]==0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator false(Matrix<T> A)
        {
            for (int i = 0; i < A.Row; i++)
            {
                for (int j = 0; j < A.Col; j++)
                {
                    if ((dynamic)A[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            for (int i = 0; i < Row; i++)
            {
                print.Append("{");
                for (int j = 0; j < Col; j++)
                {
                    print.AppendFormat("{0} ", MatrixT[i, j]);
                }
                print.Append("}");
                print.AppendLine();
            }
            return print.ToString();
        }
    }

