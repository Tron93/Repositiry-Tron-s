using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLExtensionMethods
{
    public static class ClassForDateTime
    {
        public static int printDateBorn()
        {
            Random rand = new Random();
            int dateBornHuman = rand.Next(1950, 2010);
            Console.WriteLine("Дата рождения человека = {0}", dateBornHuman);

            return dateBornHuman;
        }

        public static int returnAge(this DateTime date, int dateBorn) //(20)
        {
            if (date.Year != DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException("date", "Не верно указана текущая дата!");
            }

            if (dateBorn < 0 || dateBorn > date.Year)
            {
                throw new ArgumentOutOfRangeException("dateBorn", "Дата не может быть отрецательной или позднее текущей!");
            }

            int fullYears =  date.Year - dateBorn - 1;
            return fullYears; // TODO
        }

        public static string ToFormattedStringUtc(this DateTime date)
        {
            DateTime temp = date;
            if (date.Kind != DateTimeKind.Utc)
            {
                temp = date.ToUniversalTime();
            }

            return string.Format("{0}-{1}-{2}T{3}:{4}:{5}Z", temp.Year, temp.Month, temp.Day, temp.Hour, temp.Minute, temp.Second);
        }
    }
}
