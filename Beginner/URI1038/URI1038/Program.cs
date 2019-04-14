using System;
using System.Globalization;

namespace URI1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            double total;

            string[] values = Console.ReadLine().Split(' ');

            X = int.Parse(values[0]);
            Y = int.Parse(values[1]);

            total = 0;

            switch (X)
            {
                case 1:
                    total = Y * 4.00;
                    break;
                case 2:
                    total = Y * 4.50;
                    break;
                case 3:
                    total = Y * 5.00;
                    break;
                case 4:
                    total = Y * 2.00;
                    break;
                case 5:
                    total = Y * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
