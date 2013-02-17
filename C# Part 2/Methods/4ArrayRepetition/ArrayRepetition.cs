//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ArrayRepetition
    {
        public static void Main()
        {
            decimal[] array = new decimal[] { 1, 2, 3, 3, 4, 5, 5, 66, 66, 66, 1, 3, 66, 3, 4, 9, 0 };
            decimal checkNumber = int.Parse(Console.ReadLine());
            RepetitionCounter(array, checkNumber);
        }
        public static int RepetitionCounter(decimal[] array, decimal checker)
        {
            int counter = 0;
            foreach (var item in array)
            {
                if (item==checker)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }
    }

