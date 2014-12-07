using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAlgoritms
{
    class Cylinder
    {
        public static void VolumeCylinder()
        {
            Console.Write("\nВведите через enter радиус(R) и высоту цилиндра(H): ");
            int Radius = int.Parse(Console.ReadLine());
            int Height = int.Parse(Console.ReadLine());

            Console.WriteLine("Объём цилиндра = {0}", (Math.PI * Radius * Height).ToString());
        }
    }
}
