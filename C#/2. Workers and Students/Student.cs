using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Student:Human
    {
        public double Grade { get; private set; }

        public Student(string name, string surname, double grade)
            : base(name, surname)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("{0} | Grade: {1}", base.ToString(), this.Grade);
        }
    }

