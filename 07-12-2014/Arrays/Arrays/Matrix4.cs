using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Matrix4
    {
        public static void massive()
        {
            double count = 0;
            Console.Write("Введите высоту матрицы(n): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("\nВведите ширину матрицы(m): ");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();
            double[,] Mas = new double[n, m];
            bool[] NewMas = new bool[m];

            // заполнение массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Mas[i, j] = rand.Next(-2, 2);
                    Console.Write("{0}\t", Mas[i, j].ToString());
                    NewMas[j] = true;
                }
                Console.WriteLine("\n");
                
            }

            Console.WriteLine("\n");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    count = 0 + Mas[i, j];

                    if (count != 0)
                    {
                        NewMas[j] = false;
                    }
                }
                Console.Write("{0}\t", NewMas[j].ToString());
            }
            
            Console.ReadKey();
        }
    }
}
