using System;
using System.Globalization;

namespace URI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, volume, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = 4.0 / 3.0 * pi * R * R * R;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
