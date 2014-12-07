using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    // Console in method code
    // Variable naming
    // Method should perform only one action
    // Method naming
    // using cleanup
    // class access modifier
    // <array>.GetLength(...) method

    class Matrix1
    {
        public static void massive()
        {
            int[,] mas = new int[10,12];

            for (int i = 0; i < mas.GetLength(0); i++)
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
