using System;
using System.Globalization;

namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int prod1, prod2, units1, units2;
            double price1, price2, total;

            string[] vet = Console.ReadLine().Split(' ');
            prod1 = int.Parse(vet[0]);
            units1 = int.Parse(vet[1]);
            price1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            prod2 = int.Parse(vet[0]);
            units2 = int.Parse(vet[1]);
            price2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = units1 * price1 + units2 * price2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
