using System;
using System.Collections.Generic;
using System.IO;

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

    public class CalculateDate
    {
        private readonly IWriter writer;
        private readonly IEnumerable<int> ListOfDay2 = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private readonly IEnumerable<int> ListOfDay3 = new List<int> { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public CalculateDate(IWriter name)
        {
            writer = name;
        }

        public void StartCalculate()
        {
            bool correctYearNotEntered = true;
            bool isLeapYear = false;
            int dayNumber = 0;
            do 
            {
                Console.WriteLine("Введите год");
                int year = int.Parse(Console.ReadLine());
                isLeapYear = IsLeapYear(year);
                writer.WriteFrom(isLeapYear ? "Високосный год" : "Не високосный год");

                Console.WriteLine("Введите номер дня");
                dayNumber = int.Parse(Console.ReadLine());

                correctYearNotEntered = dayNumber < 0
                    || isLeapYear && dayNumber > 366
                    || !isLeapYear && dayNumber > 365;

                if (correctYearNotEntered)
                {
                    writer.WriteFrom("Выход за диапозон дней в году");
                }
            }
            while (correctYearNotEntered);

            IEnumerable<int> listOfDay = GetListOfDay(isLeapYear);
            DayOfMonth mon = GetMonthAndDay(dayNumber, listOfDay);
            writer.WriteFrom(string.Format("Месяц {0} день {1}", mon.Mon.ToString(), mon.Day.ToString()));
        }

        public DayOfMonth GetMonthAndDay(int dayNumber, IEnumerable<int> listOfDay)
        {
            int monthNumber = 0;
            int dayCounter = dayNumber;

            foreach (int numberOfDays in listOfDay)
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

        private IEnumerable<int> GetListOfDay(int year)
        {
            return GetListOfDay(IsLeapYear(year));
        }

        private IEnumerable<int> GetListOfDay(bool isLeapYear)
        {
            if (isLeapYear)
            {
                return ListOfDay3;
            }
            else
            {
                return ListOfDay2;
            }
        }

        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }
    }

    public interface IWriter
    { 
        void WriteFrom(string str);
    }

    public class WriterInConsole: IWriter
    {
        public virtual void WriteFrom(string str)
        {
            Console.WriteLine(str);
        }
    }

    public class WriterInFile: IWriter
    {
        public void WriteFrom(string str)
        {
            File.AppendAllText("qwdqwdqw.txt", str);
        }
    }

    public class WriterFactory
    {
        public IWriter CreateWriter()
        {
            return new MixedWriter();
        }
    }

    public class MixedWriter : WriterInConsole
    {
        //IWriter ConsoleWriter = new WriterInConsole();
        IWriter FileWriter = new WriterInFile();

        public override void WriteFrom(string str)
        {
            base.WriteFrom(str);
            FileWriter.WriteFrom(str);

        }
    }
}