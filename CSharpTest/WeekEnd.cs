 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WeekEnd
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public WeekEnd(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        public int CountWeekends()
        {
            int count = 0;

            if (StartDate == EndDate) return 0;
           
            TimeSpan time = EndDate - StartDate;
            count = time.Days;
            return count;
        }
    }
}
