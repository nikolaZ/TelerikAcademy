//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            int start = Start();
            ReadNumber(start, End(start));
        }
        static int Start()
        {
            Console.Write("Enter start number in the range [0...90] = ");
            int start = Number();
            if (start <= 1 || start >= 91)
            {
                Exception ae = new System.ArgumentOutOfRangeException();
                HandleError(ae);
                return Start();
            }
            else
            {
                return start;
            }
        }
        static int End(int start)
        {
            Console.Write("Enter end number in the range [start + 10< end < 100] = ");
            int end = Number();
            if (end >= 100 || end <= (start + 10))
            {
                Exception ae = new System.ArgumentOutOfRangeException();
                HandleError(ae);
                return End(start);
            }
            else
            {
                return end;
            }
        }
        static void ReadNumber(int start, int end)
        {
                Console.WriteLine("Enter number between {0} and {1}", start, end);
                int num = Number(); 
                int counter = 0;
                if (counter==10)
                {
                    return;
                }
                if (num <= start || num >= end)
                {
                    Exception ae = new System.ArgumentOutOfRangeException();
                    HandleError(ae);
                    ReadNumber(start, end);
                    counter++;
                }
                else
                {
                    ReadNumber(num, end);
                    counter++;
                }
        }
        static int Number()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                return number;
            }
            catch (ArgumentNullException empty)
            {
                Console.WriteLine("Invalid number." + empty.Message);
                return Number();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number.Number is NOT in the right range.");
                return Number();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
                return Number();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
                return Number();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number." + fe.Message);
                return Number();
            }
        }
        static void HandleError(Exception ex)
        {
            Console.WriteLine("Invalid number.Number is NOT in the right range.");
        }
    }
