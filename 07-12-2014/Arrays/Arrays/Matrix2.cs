﻿using System;
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
    // Error in the last loop!
    // 'if' formatting
    // Duplicate code

    class Matrix2
    {
        public static void massive()
        {
            int count = 0;
            Console.Write("Введите размерность матрицы(n): ");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();
            double[,] mas = new double[n, n];

            ConsoleColor currentColor = Console.ForegroundColor;
            for (int i = 0; i < n; i++) // заполнение массива
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i,j] = rand.Next(-5, 5);
                    if (mas[i,j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (j == n - 1 - i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write("{0}\t", mas[i, j]);
                    Console.ForegroundColor = currentColor;

                    
                }
                Console.WriteLine("\n");
            }


            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (mas[i, j] == 0) count++;
                }
            }
            Console.WriteLine(count);   // выше главной диагонали
            count = 0;

            for (int j = 0; j < n - 1; j++) 
            {
                for (int i = n - 1; i > j; i--)
                {
                    if (mas[i, j] == 0) count++;
                }
            }
            Console.WriteLine(count); // ниже главной диагонали
            count = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (mas[i, j] == 0) count++;
                }
            }
            Console.WriteLine(count); // выше побочной диагонали
            count = 0;

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = n - 1; j > n - 1 - i; j--)
                {
                    if (mas[i, j] == 0) count++;
                }
            }
            Console.WriteLine(count); // ниже побочной диагонали
        
        Console.ReadKey();
        }
        
    }
}
