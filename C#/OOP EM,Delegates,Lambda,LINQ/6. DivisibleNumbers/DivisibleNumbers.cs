//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DivisibleNumbers
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] numbers = new int[20];
        numbers[0] = 21;// Assuring at least one number will be divisible by both 7 and 3
        for (int i = 1; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(0, 200);
        }
        foreach (int number in numbers)
        {
            Console.Write("{0}, ", number);
        }
        Console.WriteLine();
        var sortedNumbersLINQ = from number in numbers where number % 21 == 0 select number;
        foreach (var item in sortedNumbersLINQ)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        var sortedNumbers = numbers.Where(number => number % 7 == 0 && number % 3 == 0);
        foreach (var item in sortedNumbers)
        {
            Console.WriteLine(item);
        }
    }
}

