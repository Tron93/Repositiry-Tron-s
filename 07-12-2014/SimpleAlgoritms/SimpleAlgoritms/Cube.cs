using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAlgoritms
{
    // Console in method code
    // Environment.NewLine
    // Excessive parentheses around Math.Pow
    // Variable naming
    // Method does two actions (actually more, taking Console into account) instead of one
    // Method naming
    // using cleanup
    // Math.Pow can be used
    // class access modifier

    class Cube
    {
        public static void VolumeCube()
        {
            Console.Write("Ввести ребро куба: ");
            int RebroKuba = int.Parse(Console.ReadLine());

            Console.WriteLine("\nОбъём куба = {0}", (Math.Pow(RebroKuba, 3)).ToString());
            Console.WriteLine("\nПлощадь боковой поверхности куба = {0}", (6 * RebroKuba * RebroKuba).ToString());
        }
    }
}
