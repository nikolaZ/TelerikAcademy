using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Worker:Human,IComparable<Worker>
    {
        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string name, string surname, decimal weekSalary,int workingHoursDaily)
            : base(name, surname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workingHoursDaily;
        }

        public decimal MoneyPerHour()
        {
            const int DaysInWeek = 5;
            return Math.Round(this.WeekSalary / DaysInWeek / this.WorkHoursPerDay, 2);
        }
        public override string ToString()
        {
            return string.Format("{0}\n Week Salary: {1:C}\n Per Hour: {2:C}", base.ToString(), this.WeekSalary,MoneyPerHour());
        }

        public int CompareTo(Worker worker)
        {
            if (this.MoneyPerHour().CompareTo(worker.MoneyPerHour()) == 0)
            {
                return this.WorkHoursPerDay.CompareTo(worker.WorkHoursPerDay);
            }

            return this.MoneyPerHour().CompareTo(worker.MoneyPerHour());
        }
    }

