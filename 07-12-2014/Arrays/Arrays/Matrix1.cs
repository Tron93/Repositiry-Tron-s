using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Matrix1
    {
        public static void massive()
        {
            int[,] mas = new int[10,12];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    mas[i, j] = i + 2 * j;
                    Console.Write("{0}\t", mas[i, j].ToString());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
