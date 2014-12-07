using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAlgoritms
{
    class Rectangle
    {
        public static void SizesRectangle()
        {
            Console.Write("\nВведите через enter стороны прямоугольника(a,b): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Периметр прямоугольника = {0}, площадь = {1}, диагональ прямоугольника = {2}",
                (2 * (a + b)).ToString(), (a * b).ToString(), Math.Sqrt(a *a + b* b).ToString());
        }
    }
}
