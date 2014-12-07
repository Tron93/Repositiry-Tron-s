using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Matrix5
    {
        public static void massive()
        {
            double count = 1;
            double max = -99999, min = 99999;
            Console.Write("Введите высоту матрицы(n): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("\nВведите ширину матрицы(m): ");
            int n = int.Parse(Console.ReadLine());
            int k = Math.Max(n, m);

            Random rand = new Random();
            double[,] Mas = new double[n, m];
            double[] VektorB = new double[k];

            // заполнение массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Mas[i, j] = rand.Next(-20, 20);
                    Console.Write("{0}\t", Mas[i, j].ToString());
                }
                Console.WriteLine("\n");
                
            }

            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    count = count * Mas[i, j];
                }
                VektorB[i] = count;
                Console.Write("{0}\t", VektorB[i].ToString());
                count = 1;
            }
            Console.Write(" - произведение элементов строк\n");


            count = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    count = count + Mas[i, j];
                }
                VektorB[j] = count / n;
                Console.Write("{0}\t", VektorB[j].ToString("0.##"));
                count = 0;
            }
            Console.Write(" - ср. арифм-кое элементов столбцов\n");


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    max = Math.Max(max, Mas[i, j]);
                    min = Math.Min(min, Mas[i, j]);
                }
                VektorB[i] = max - min;
                Console.Write("{0}\t", VektorB[i].ToString());
                max = -99999; min = 99999;
            }
            Console.Write(" - разность элементов строк\n");


            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (Mas[i, j] < 0)
                    {
                        VektorB[j] = Mas[i, j];
                        break;
                    }
                }
                Console.Write("{0}\t", VektorB[j].ToString());
            }
            Console.Write(" - 1-ые отрицательный элемент столбцов\n");

            Console.ReadKey();
        }
    }
}
