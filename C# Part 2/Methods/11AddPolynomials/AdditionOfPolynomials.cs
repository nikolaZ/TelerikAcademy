//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5  501
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class AdditionOfPolynomials
    {
        static void Main()
        {
            int[] a = new int[] { 2, 0, 6 };
            int[] b = new int[] { 2, 5,};
            Print(ReverseInput(a));
            Print(ReverseInput(b));
            Print(Add(ReverseInput(a), ReverseInput(b)));
        }
        static int[] Add(int[] a, int[] b)
        {
            int[] result = new int[Math.Max(a.Length,b.Length)];
            int i = 0;
            if (a.Length > b.Length)
            {
                return Add(b, a);
            }
            for (; i < a.Length; i++)
            {
                result[i] = a[i] + b[i];
            }
            for (; i< b.Length; i++)
            {
                result[i] = b[i];
            }
            return result;
        }
        static void Print(int[] polynom)
        {
            for (int i = polynom.Length - 1; i >= 0; i--)
            {
                if (i != polynom.Length - 1 && polynom[i] != 0)
                {
                    if (polynom[i] > 0)
                    {
                        Console.Write("+");
                    }
                }
                if (polynom[i]!=0&&i!=0)
                {
                    Console.Write("{0}x^{1}", polynom[i],i);
                }
                else if(i==0)
                {
                    Console.Write("{0}", polynom[i]);
                }
            }
            Console.WriteLine();
        }
        static int[] ReverseInput(int[] c)
        {
            int[] reversed = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                reversed[c.Length - i - 1] = c[i];
            }
            return reversed;
        }
    }

