//Write a method that calculates the number of workdays between today and given date,
//passed as parameter. Consider that workdays are all days from Monday to Friday except
//a fixed list of public holidays specified preliminary as array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WorkDaysSum
{
    static void Main()
    {
        int period = 0;
        DateTime day=new DateTime();
        Days(out period,out day);
        WorkDays(period, day);
    }
    static DateTime[] Holidays()
    {
        int currentYear = DateTime.Now.Year;
        DateTime[] holidays = new DateTime[]{
            new DateTime(currentYear, 1, 1),
            new DateTime(currentYear, 3, 3),
            new DateTime(currentYear, 5, 1),
            new DateTime(currentYear, 5, 2),
            new DateTime(currentYear, 5, 6),
            new DateTime(currentYear, 5, 24),
            new DateTime(currentYear, 9, 22),
            new DateTime(currentYear, 12, 24),
            new DateTime(currentYear, 12, 25),
            new DateTime(currentYear, 12, 26),};
        return holidays;
    }
    static int Days(out int period,out DateTime startDay)
    {
        Console.Write("Enter an end date in format: YYYY.MM.DD: ");
        string[] endDate = Console.ReadLine().Split('.');
        int day = int.Parse(endDate[2]);
        int month = int.Parse(endDate[1]);
        int year = int.Parse(endDate[0]);
        startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        period = 0;
        period = Math.Abs((endDay - startDay).Days);
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }
        return period;
    }
    static void WorkDays(int period,DateTime start)
    {
        int workDays = 0;
        bool holiday = false;
        start = DateTime.Today;
        for (int i = 0; i < period; i++)
        {
            start = start.AddDays(1);
            if (start.DayOfWeek != DayOfWeek.Sunday && start.DayOfWeek != DayOfWeek.Saturday)
            {
                foreach (var holidays in Holidays())
                {
                    if (start == holidays)
                    {
                        holiday = true;
                        break;
                    }
                }
                if (!holiday)
                {
                    workDays++;
                }
               holiday = false;
            }
        }
        Console.WriteLine(workDays);
    }
}
    


