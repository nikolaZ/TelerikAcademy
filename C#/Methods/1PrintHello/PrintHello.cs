//Write a method that asks the user for his name
//and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.
using System;
using System.Text;

    class PrintHello
    {
        static void Main()
        {          
            PrintName();
        }
        static void PrintName()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}",name);
        }
    }

