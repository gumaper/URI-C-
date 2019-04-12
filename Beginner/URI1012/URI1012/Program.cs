using System;
using System.Globalization;

namespace URI1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi = 3.14159;
            double TRIANGLE, CIRCLE, TRAPEZIUM, SQUARE, RECTANGLE;

            string[] values = Console.ReadLine().Split(' ');
            A = double.Parse(values[0], CultureInfo.InvariantCulture);
            B = double.Parse(values[1], CultureInfo.InvariantCulture);
            C = double.Parse(values[2], CultureInfo.InvariantCulture);

            TRIANGLE = A * C / 2.0;
            CIRCLE = pi * C * C;
            TRAPEZIUM = (A + B) / 2.0 * C;
            SQUARE = B * B;
            RECTANGLE = A * B;

            Console.WriteLine("TRIANGULO: " + TRIANGLE.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCLE.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIUM.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + SQUARE.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + RECTANGLE.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
