using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLExtensionMethods
{
    public static class ClassForIntAndDouble
    {
        public static int returnHalfOfInt(this int chislo)
        {
            return chislo / 2;
        }

        public static double returnHalfOfDouble(this double chislo)
        {
            return chislo / 2;
        }
    }
}
