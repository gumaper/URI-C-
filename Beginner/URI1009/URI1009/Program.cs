using System;
using System.Globalization;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salary, sales, total;

            name = Console.ReadLine();
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (sales * 0.15) + salary;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
