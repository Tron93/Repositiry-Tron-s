using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAlgoritms
{
    class Triangle
    {
        private static double[] CalculateSides()
        {
            double[] Sides = new double[3];
            double[] Points = ReadPoints();

            Sides[0] = Math.Sqrt((Points[0] - Points[2]) * (Points[0] - Points[2])
                    + (Points[1] - Points[3]) * (Points[1] - Points[3]));

            Sides[1] = Math.Sqrt((Points[2] - Points[4]) * (Points[2] - Points[4])
                    + (Points[3] - Points[5]) * (Points[3] - Points[5]));

            Sides[2] = Math.Sqrt((Points[0] - Points[4]) * (Points[0] - Points[4])
                   + (Points[1] - Points[5]) * (Points[1] - Points[5]));

            return Sides;
        }

        private static double[] ReadPoints()
        {
            Console.Write("\nВведите через пробел координаты точек треугольника: ");
            string[] GetSides = Console.ReadLine().Split(' ');
            double[] Points = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Points[i] = int.Parse(GetSides[i]);
            }

            return Points;
        }

        public static void SquareAndPerimetr()
        {
            double[] Sides = CalculateSides();

            double p = (Sides[1] + Sides[2] + Sides[0]) / 2;
            double P_triangle = p * 2;

            double S_triangle = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            Console.WriteLine("\nПериметр треугольника = {0}, а площадь = {1}", P_triangle.ToString(), S_triangle.ToString());
        }

        public static void FormulaGerona()
        {
            Console.Write("\nВведите через пробел стороны треугольника(a,b,c): ");
            string[] GetSides = Console.ReadLine().Split(' ');
            double[] Sides = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Sides[i] = int.Parse(GetSides[i]);
            }

            double p = (Sides[1] + Sides[2] + Sides[0]) / 2;
            double S_triangle = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            Console.WriteLine("Периметр треугольника = {0}", S_triangle.ToString());
        }
    }
}
