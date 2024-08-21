using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W__Extension_Methods
{
    public static class DateTimeHelper
    {
        public static bool IsWeekEnd(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday;
        }
    }
}
