using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public byte? Age { get; set; }

        public Student(string firstName,string secondName):this( firstName,secondName,null)
        {
        }
        public Student(string firstName, string secondName, byte? age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
        public static void FirstBeforeLastName(Student[] allStudents)
        {
            var sorted = from s in allStudents where s.FirstName.CompareTo(s.SecondName) < 0 select s;
            foreach (var student in sorted)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
            }
        }
        public static void Aged18to24(Student[] allStudents)
        {
            var sorted = from s in allStudents where s.Age >= 18&&s.Age<=24 select s;
            foreach (var student in sorted)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
            }
        }
        public static void DescendingOrder(Student[] allStudents)
        {
            var sorted = allStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.SecondName);
            foreach (var student in sorted)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
            }
        }
        public static void DescendingOrderLINQ(Student[] allStudents)
        {
            var sorted = from student in allStudents 
                         orderby student.FirstName descending, student.SecondName descending 
                         select student;
            foreach (var student in sorted)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
            }
        }
    }

