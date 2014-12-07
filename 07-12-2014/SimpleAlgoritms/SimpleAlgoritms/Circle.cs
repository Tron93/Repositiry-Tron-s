using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAlgoritms
{
    // Console in method code
    // Environment.NewLine
    // Variable naming
    // Method should perform only one action
    // Method naming
    // using cleanup
    // Math.Pow can be used
    // class access modifier

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
