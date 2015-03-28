using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLExtensionMethods
{
    public static class ClassForTimeSpan
    {
        public static double returnNumberOfWeeks(this TimeSpan timeSpan)
        {
            return timeSpan.TotalDays / 7;
        }
    }
}
