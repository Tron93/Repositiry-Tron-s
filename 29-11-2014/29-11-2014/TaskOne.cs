using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_11_2014
{
    class TaskOne
    {
        private const int three = 3;

        public static void Main()
        {
            int[] A = new int[three];

            for (int i = 0; i < three; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            
            int[,] mas = FillMatrix(A);

            for (int i = 0; i < three; i++)
            {
                for (int j = 0; j < three; j++)
                {
                    Console.Write("{0}\t", mas[i, j].ToString());
                }

                Console.WriteLine();
            }



            Console.ReadKey();
        }

        private static int[,] FillMatrix(int[] A)
        {
            int[,] result = new int[three, three];
            for (int i = 0; i < three; i++)
            {
                for (int j = 0; j < three; j++)
                {
                    result[i, j] = A[i] - 3 * A[j];
                }
            }

            return result;
        }
    }
}
