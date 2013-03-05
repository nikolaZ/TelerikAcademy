//3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
//4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24
//5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the
//students by first name and last name in descending order. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
        static void Main(string[] args)
        {
            Student pesho = new Student("Pesho", "Dimitrov",17);
            Student gosho = new Student("Georgi", "Angelov",18);
            Student vanko = new Student("Ivan", "Ivanov",24);
            Student angel = new Student("Angel", "Ivanov",26);
            Student vanio = new Student("Ivan", "Petrov", 22);
            Student[] allStudents = new Student[] { pesho, gosho, vanko, angel,vanio };
            Student.FirstBeforeLastName(allStudents);
            Console.WriteLine();
            Student.Aged18to24(allStudents);
            Console.WriteLine();
            Student.DescendingOrder(allStudents);
            Console.WriteLine();
            Student.DescendingOrderLINQ(allStudents);
        }
    }

