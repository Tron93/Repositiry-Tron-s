using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_12_2014
{
    public enum Month
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    public class MonthDay
    {
        public Month Mon { get; private set; }
        public int Day { get; private set; }

        public MonthDay(Month mon, int day)
        {
            Mon = mon;
            Day = day;
        }
    }

    public class CalcDate
    {
        private static readonly IEnumerable<int> ListOfDay = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public void Main()
        {
            int dayNumber = int.Parse(Console.ReadLine());
            MonthDay mon = GetMonthAndDay(dayNumber);
            Console.WriteLine("Месяц {0} день {1}", mon.Mon.ToString(), mon.Day.ToString());
        }

        public static MonthDay GetMonthAndDay(int dayNumber)
        {
            int monthNumber = 0;
            int dayCounter = dayNumber;
            foreach (int numberOfDays in ListOfDay)
            {
                if (dayCounter > numberOfDays)
                {
                    dayCounter -= numberOfDays;
                    monthNumber++;
                }
                else
                {
                    break;
                }
            }

            return new MonthDay((Month)monthNumber, dayCounter);
        }
    }
}
