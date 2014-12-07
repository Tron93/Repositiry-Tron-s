using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAlgoritms
{
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
