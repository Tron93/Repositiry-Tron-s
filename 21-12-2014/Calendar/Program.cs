using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDate calk = new CalculateDate();
            calk.StartCalculate();

            Console.ReadKey();
        }
    }
}
