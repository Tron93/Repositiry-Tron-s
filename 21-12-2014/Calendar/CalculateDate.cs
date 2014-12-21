using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar
{
    public enum Month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public class DayOfMonth
    {
        public Month Mon { get; private set; }
        public int Day { get; private set; }

        public DayOfMonth(Month mon, int day)
        {
            Mon = mon;
            Day = day;
        }
    }

    public class CalculateDate//: DateTime
    {
        // Assigned but never used
        DateTime date = new DateTime();

        // Is this one really needed?
        private static IEnumerable<int> ListOfDay;

        // Names
        private static readonly IEnumerable<int> ListOfDay2 = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly IEnumerable<int> ListOfDay3 = new List<int> { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Labels are bad (most of the time)
        public void StartCalculate()
        {
            m: Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());
            CalculateYear(year);
            
            Console.WriteLine("Введите номер дня");
            int dayNumber = int.Parse(Console.ReadLine());

            try
            {
                if (ListOfDay == ListOfDay3 && (dayNumber < 0 || dayNumber > 366 ) || ListOfDay == ListOfDay2 && (dayNumber < 0 || dayNumber > 365 ))
                    throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Выход за диапозон дней в году");
                goto m;
            }

            
            DayOfMonth mon = GetMonthAndDay(dayNumber);
            Console.WriteLine("Месяц {0} день {1}", mon.Mon.ToString(), mon.Day.ToString());
        }

        public static DayOfMonth GetMonthAndDay(int dayNumber)
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

            return new DayOfMonth((Month)monthNumber, dayCounter);
        }

        // Console?
        // Not very good name for this method
        // Can get rid of else branch
        // Why return here?
        public static IEnumerable<int> CalculateYear(int year)
        {
            if (year % 4 == 0 & (year % 100 != 0 | year % 400 == 0))
            {
                Console.WriteLine("Високосный год");
                ListOfDay = ListOfDay3;
            }
            else
            {
                Console.WriteLine("Не високосный год");
                ListOfDay = ListOfDay2;
            }
            return ListOfDay;
        }
    }
}