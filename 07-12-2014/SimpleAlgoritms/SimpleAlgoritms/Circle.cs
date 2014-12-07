using System;

namespace SimpleAlgoritms
{
    internal sealed class Circle
    {
        public static double CalculateSquareCircle(int lengthCircle)
        {
            return (Math.Pow(lengthCircle, 2.0) / (4 * Math.PI)); // S = l^2 / (4*P)
        }

        public static void PrintSquareCircle()
        {
            Console.Write(Environment.NewLine + "Ввести длину окружности: ");
            int lengthCircle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Площадь окружности = {0}", CalculateSquareCircle(lengthCircle).ToString());
        }
    }
}
