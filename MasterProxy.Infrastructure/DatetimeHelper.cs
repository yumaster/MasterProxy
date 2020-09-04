using System;
using System.Collections.Generic;
using System.Text;

namespace MasterProxy.Infrastructure
{
    public class DateTimeHelper
    {
        public static double TimeRange(DateTime From, DateTime To)
        {
            return (To - From).TotalMilliseconds;
        }
    }
}
