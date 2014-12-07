using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAlgoritms
{
    class Circle
    {
        public static void SquareCircle()
        {
            Console.Write("\nВвести длину окружности: ");
            int LengthCircle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nПлощадь окружности = {0}", ((LengthCircle * LengthCircle) / (4 * Math.PI)).ToString());  // S = l^2 / (4*P)
        }
    }
}
