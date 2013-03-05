//Implement a set of extension methods for IEnumerable<T> that implement
//the following group functions: sum, product, min, max, average.
using System;
using System.Collections.Generic;

public class ExtensionsMain
    {
        static void Main()
        {
            List<double> numbers = new List<double>();
            numbers.Add(4.3d);
            numbers.Add(5.2d);
            numbers.Add(1.3d);
            numbers.Add(7.4d);
            numbers.Add(2.2d);

            Console.WriteLine("Sum of elements: {0}", numbers.Sum());
            Console.WriteLine("Minimum element : {0}",numbers.Min());
            Console.WriteLine("Maximum element : {0}", numbers.Max());
            Console.WriteLine("Average : {0}",numbers.Avg());
            Console.WriteLine("Product of elements : {0}",numbers.Product());
        }
    }

