using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_11_2014
{
    class TaskTwo
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] mas = new int[N, N];

            for (int i = 0; i < N; i++ )
            {
                for (int j = 0; j < N; j++ )
                {
                    mas[i, j] = rand.Next(0, 100);
                    Console.Write("{0}\t", mas[i, j].ToString());
                }

                Console.WriteLine();
            }

            bool[,] rowMins = new bool[N, N];
            for (int i = 0; i < N; i++)
            {
                int minIndex = 0;
                for (int j = 0; j < N; j++)
                {
                    if (mas[i, j] < mas[i, minIndex])
                    {
                        minIndex = j;
                    }
                }

                rowMins[i, minIndex] = true;
            }

            bool[,] colMaxs = new bool[N, N];
            for (int j = 0; j < N; j++)
            {
                int maxIndex = 0;
                for (int i = 0; i < N; i++)
                {
                    if (mas[i, j] > mas[maxIndex, j])
                    {
                        maxIndex = i;
                    }
                }

                colMaxs[maxIndex, j] = true;
            }

            Console.WriteLine();
            PrintBoolMatrix(rowMins);
            Console.WriteLine();
            PrintBoolMatrix(colMaxs);

            var saddlePoints = FindSaddlePoints(rowMins, colMaxs);
            foreach (var point in saddlePoints)
            {
                Console.WriteLine("Седловая точка: [{0}, {1}]", point.Item1.ToString(), point.Item2.ToString());
            }
           
            Console.ReadKey();
        }

        private static IEnumerable<Tuple<int, int>> FindSaddlePoints(bool[,] rowMins, bool[,] colMaxs)
        {
            List<Tuple<int, int>> result = new List<Tuple<int, int>>(rowMins.GetLength(0));
            for (int i = 0; i < rowMins.GetLength(0); i++)
            {
                for (int j = 0; j < rowMins.GetLength(1); j++)
                {
                    if (rowMins[i, j] && colMaxs[i, j])
                    {
                        result.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            return result;
        }

        private static void PrintBoolMatrix(bool[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matrix[i, j].ToString());
                }

                Console.WriteLine();
            }
        }
    }
}
