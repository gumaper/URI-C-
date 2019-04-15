using System;
using System.Globalization;

namespace URI1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string[] values = Console.ReadLine().Split();
            a = double.Parse(values[0], CultureInfo.InvariantCulture);
            b = double.Parse(values[1], CultureInfo.InvariantCulture);
            c = double.Parse(values[2], CultureInfo.InvariantCulture);

            if (a < (b + c) && c < (a + b) && b < (a + c))
            {
                Console.WriteLine("Perimetro = " + (a + b + c).ToString("0.0", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Area = " + (((a + b) * c) / 2).ToString("0.0", CultureInfo.InvariantCulture));
            }
        }
    }
}
