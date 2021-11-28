using CSharpTest;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2012, 4, 23);
            DateTime date2 = new DateTime(2012, 4, 25);
            TimeSpan date = date2 - date1;
            WeekEnd week = new WeekEnd(date1, date2);
           
            int r =  week.CountWeekends();
            Console.WriteLine(r);

            DateTime startDate = new DateTime(2021, 12, 1);
            int count = 10;

            DateTime result = new WorkDayCalculator().Calculate(startDate, count, null);
            Console.WriteLine(result);

            DateTime startDate1 = new DateTime(2021, 4, 21);
            int count1 = 5;
            WeekEnd[] weekends = new WeekEnd[2]
            {
                new WeekEnd(new DateTime(2021, 4, 23), new DateTime(2021, 4, 25)),
                new WeekEnd(new DateTime(2021, 4, 29), new DateTime(2021, 4, 29))
            };

            DateTime result1 = new WorkDayCalculator().Calculate(startDate1, count1, weekends);
           
            Console.WriteLine(result1);

            DateTime startDate2 = new DateTime(2021, 4, 21);
            int count2 = 5;
            WeekEnd[] weekends2 = new WeekEnd[1]
            {
                new WeekEnd(new DateTime(2021, 4, 23), new DateTime(2021, 4, 25))
            };

            DateTime result2 = new WorkDayCalculator().Calculate(startDate2, count2, weekends2);

            Console.WriteLine(result2);
        }
    }
}
