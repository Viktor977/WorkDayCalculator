using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            int count = 0;
            if (weekEnds == null)
            {
                count = dayCount - 1;
            }
            else
            {
                count = dayCount + CountWeekDay(weekEnds);
            }
            
            TimeSpan time = new TimeSpan(count, 0, 0, 0);
            DateTime end = startDate.Add(time);
            return end;
        }

        public int CountWeekDay(WeekEnd[] weekEnds)
        {
            int count = 0;  

            if (weekEnds == null) return 0; 

            for(int i = 0; i < weekEnds.Length; ++i)
            {
                count += weekEnds[i].CountWeekends();
            }

            return count;
        }
    }
}
