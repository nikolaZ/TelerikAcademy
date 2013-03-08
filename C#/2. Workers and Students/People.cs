using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class People
    {
        static void Main(string[] args)
        {
            Student[] students = {
                                     new Student("Georgi", "Georgiev", 4.5),
                                     new Student("Petyr", "Georgiev", 6),
                                     new Student("Dimityr", "Petrov", 5.5),
                                     new Student("Georgi", "Todorov", 4.45),
                                     new Student("Nikolay", "Vladimirov", 4.3),
                                     new Student("Vladislav", "Kovachev", 6),
                                     new Student("Nikola", "Borisov", 6),
                                     new Student("Ivan", "Monev", 5),
                                     new Student("Stanislav", "Dimitrov", 5.25),
                                     new Student("Daniel", "Metodiev", 5.65),};
            students = students.OrderBy(student => student.Grade).ToArray();
            foreach (Student st in students)
            {
                Console.WriteLine(st);
            }
            Worker[] workers = {
                                     new Worker("Georgi", "Petkov", 250,8),
                                     new Worker("Plamen", "Georgiev",250, 6),
                                     new Worker("Petyr", "Petrov", 384.55M,8),
                                     new Worker("Minko", "Minkov", 150,4),
                                     new Worker("Nikolay", "Vladimirov", 99.8M,4),
                                     new Worker("Vladimir", "Kovachevski", 266.9M,8),
                                     new Worker("Nikola", "Belov", 450.2M,8),
                                     new Worker("Ivan", "Ivanov", 55.87M,3),
                                     new Worker("Stoyo", "Nenov", 301,8),
                                     new Worker("Rumen", "Petkov",28.9M,2),};
            
            workers = workers.OrderByDescending(w => w ).ToArray();
            foreach (Worker w in workers)
            {
                Console.WriteLine(w);
            }
            List<Human> humans = new List<Human>();
            humans.AddRange(workers);
            humans.AddRange(students);
            humans.Sort();
            //humans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.Surname).ToList();
            foreach (Human h in humans)
            {
                Console.WriteLine("{0} {1} {2}",h.GetType(),h.FirstName,h.Surname);
            }

        }                                     
    }

