using System;
using System.Globalization;

namespace URI1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, R1, R2;

            string[] values = Console.ReadLine().Split(' ');

            A = double.Parse(values[0], CultureInfo.InvariantCulture);
            B = double.Parse(values[1], CultureInfo.InvariantCulture);
            C = double.Parse(values[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2.0) - 4 * A * C;

            if (A == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + R1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("f5", CultureInfo.InvariantCulture));
            }
        }
    }
}
