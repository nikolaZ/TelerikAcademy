//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Square
{
    static void Main()
    {
        SquareRoot();
    }
    static void SquareRoot()
    {
        try
        {
            double number = double.Parse(Console.ReadLine());
            if (number < 0)
            {
                 throw new System.ArithmeticException();
            }
            number = Math.Sqrt(number);
            Console.WriteLine(number);
        }
        catch (ArgumentNullException empty)
        {
            Console.WriteLine("Invalid number." +empty.Message);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid number."+fe.Message);
        }
        catch(ArithmeticException)
        {
            Console.WriteLine("Sqrt for negative numbers is NOT defined!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

}

