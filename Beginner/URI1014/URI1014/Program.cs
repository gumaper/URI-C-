using System;
using System.Globalization;

namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance;
            double spentFuel, kmL;

            distance = int.Parse(Console.ReadLine());
            spentFuel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kmL = distance / spentFuel;

            Console.WriteLine(kmL.ToString("f3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
