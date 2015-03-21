using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int chisloInt = 100;
            double chilsoDouble = 1200;
            int[] mas = new int[11];
            Random rand = new Random();
            List<int> list = new List<int>();
            List<string> stringList = new List<string>() { "table", "computer", "mouse", "telephon" };
            DateTime date = DateTime.Now;
            TimeSpan time = new TimeSpan(rand.Next(10, 120), rand.Next(0, 23), rand.Next(0, 59), rand.Next(0, 59));

            for (int i = 0; i < 11; i++)
            {
                mas[i] = i + 5;
                list.Add(i + 5);
            }

            //Enumarable
            Console.WriteLine("Сумма элементов массива под чётными номерами = {0}", mas.countSumOfEnumerableForEvenElements());
            Console.WriteLine("Сумма элементов списка под нечётными номерами = {0}", list.countSumOfEnumerableForOddElements());

            Console.WriteLine("Список элементов на чётных местах:");
            foreach (var item in stringList.returnListInEnumerableForEvenElements())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Список элементов на нечётных местах:");
            foreach (var item in stringList.returnListInEnumerableForOddElements())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Изначальный список элементов:");
            foreach (var item in list)
            {
                Console.Write("{0}_", item);
            }
            Console.WriteLine();

            Console.WriteLine("Список перемешанных элементов:");
            foreach (var item in list.returnMixEnumerable())
            {
                Console.Write("{0}_", item);
            }
            Console.WriteLine();

            // Random
            Console.WriteLine("Случайная строка из латинских символов и цифр: {0}", rand.getStringFromRandom());
            Console.Write("Введите количество чисел: ");
            Console.WriteLine("Строка случайных чисел: {0}", string.Join(", ", rand.getLisOfNumbersByRandom(10, 0, 20).ToArray()));
            Console.Write("Введите количество чисел от одного до десяти: ");
            Console.WriteLine("Строка случайных различных чисел: {0}", rand.getLisOfDifferentNumbersByRandom());

            //DateTime
            Console.WriteLine("Человеку {0} лет", date.returnAge(ClassForDateTime.printDateBorn()));
            //Console.WriteLine("Текущая дата: {0}", date.returnCurrentDate());
            Console.WriteLine(date.ToFormattedStringUtc());
            
            // Int and Double
            Console.WriteLine("Половина от числа {0} = {1}", chisloInt, chisloInt.returnHalfOfInt());
            Console.WriteLine("Половина от числа {0} = {1}", chilsoDouble, chilsoDouble.returnHalfOfDouble());

            //TimeSpan
            Console.WriteLine("Интервал времени: {0} дней, {1} часов, {2} минут, {3} секунд ", time.Days, time.Hours, time.Minutes, time.Seconds);
            Console.WriteLine("Количество недель = {0}", time.returnNumberOfWeeks());

            Console.ReadKey();
        }
    }
}
