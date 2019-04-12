using System;
using System.Globalization;

namespace URI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, averageSpeed, distance;
            double liters;

            hours = int.Parse(Console.ReadLine());
            averageSpeed = int.Parse(Console.ReadLine());

            distance = hours * averageSpeed;

            liters = (double) distance / 12;

            Console.WriteLine(liters.ToString("f3", CultureInfo.InvariantCulture));        
        }
    }
}
