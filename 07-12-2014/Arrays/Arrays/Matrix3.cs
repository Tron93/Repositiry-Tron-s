using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Matrix3
    {
        public static void massive()
        {
            double count = 1;
            Console.Write("Введите высоту матрицы(m): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("\nВведите ширину матрицы(n): ");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();
            double[,] Mas = new double[m,n];
            double[] NewMas = new double[m];

            // заполнение массива
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    Mas[i, j] = rand.Next(1, 10);
                    Console.Write("{0}\t", Mas[i, j].ToString());
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine("\n");
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    NewMas[i] +=Mas[i, j];
                }
                Console.Write("{0}\t", NewMas[i].ToString());
            }
            Console.Write(" - сумма элементов строк\n");


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    count = count * Mas[i, j];
                }
                NewMas[i] = count;
                Console.Write("{0}\t", NewMas[i].ToString());
                count = 1;
            }
            Console.Write(" - произведение элементов строк\n");


            NewMas = new double[m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    NewMas[i] += Mas[i, j];
                }

                NewMas[i] /= n;
                Console.Write("{0}\t", (NewMas[i]).ToString("0.##"));
                
            }
            Console.Write(" - ср.е арифм-кое элементов строк\n");

            Console.ReadKey();
        }

    }
}