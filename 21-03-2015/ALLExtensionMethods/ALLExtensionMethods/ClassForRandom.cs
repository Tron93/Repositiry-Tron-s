using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLExtensionMethods
{
    public static class ClassForRandom
    {
        public static string getStringFromRandom(this Random rand) //(10)
        {
            int lengString = rand.Next(5, 20);

            StringBuilder randSrting = new StringBuilder(lengString);
            char symbol = ' ';


            for (int i = 0; i < lengString; i++)
            {
                int change = rand.Next(1, 64);

                if (change <= 27)
                {
                    symbol = Convert.ToChar(rand.Next(65, 90));
                }
                else if (change <= 54)
                {
                    symbol = Convert.ToChar(rand.Next(97, 122));
                }
                else if (change <= 64)
                {
                    symbol = Convert.ToChar(rand.Next(48, 57));
                }

                randSrting.Append(symbol);
            }

            return randSrting.ToString();
        }

        public static IEnumerable<int> getLisOfNumbersByRandom(this Random random, int number, int min, int max) //(8)
        {
            List<int> numbers = new List<int>(number);
            for (int i = 0; i < number; i++)
            {
                int change = random.Next(min, max);
                numbers.Add(change);
            }

            return numbers;
        }

        public static string getLisOfDifferentNumbersByRandom(this Random random) //(9)
        {
            string randSrting = "";
            int[] helpMas = new int[10];
            int t = 0;
            int s = 0;

            //int lengString = int.Parse(Console.ReadLine());
            int lengString = 8;

            if (lengString < 1 || lengString > 10)
            {
                throw new ArgumentOutOfRangeException("lengString", "Выход за допустимое значение [1, 10]!");
            }

            while (randSrting.Length != lengString)
            {
                int change = random.Next(0, 10);

                for (int i = 0; i < lengString; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (change == helpMas[j])
                        {
                            t -= 100;
                        }
                    }
                }
                if (t == 0)
                {
                    randSrting += change;
                    helpMas[s] = change;
                    s++;
                }
                t = 0;
            }

            return randSrting;
        }
    }
}
