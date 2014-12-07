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
    // class access modifier
    // Duplicate code!!!
    // TimeSpan struct

    class CountTime
    {
        public static void Time()
        {
            double hours, minuts;

            Console.Write("\nВведите через двоеточие время, когда ученик приступил к заданию(h1:min1): ");
            string[] TimeStart = Console.ReadLine().Split(':');
            int h1 = int.Parse(TimeStart[0]);
            int min1 = int.Parse(TimeStart[1]);

            Console.WriteLine("\nВведите через двоеточие время, когда ученик закончил решать(h2:min2): ");
            string[] TimeFinish = Console.ReadLine().Split(':');
            int h2 = int.Parse(TimeFinish[0]);
            int min2 = int.Parse(TimeFinish[1]);

            hours = ((h2 * 60 + min2) - (h1 * 60 + min1)) / 60;
            minuts = ((h2 * 60 + min2) - (h1 * 60 + min1)) % 60;

            Console.WriteLine("Ученик решал задачу {0} час(а/ов) {1}  минут(у/ы)", hours.ToString(), minuts.ToString());
        }
    }
}
