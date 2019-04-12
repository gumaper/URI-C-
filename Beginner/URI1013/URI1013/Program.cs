using System;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, maior;

            string[] values = Console.ReadLine().Split(' ');
            a = int.Parse(values[0]);
            b = int.Parse(values[1]);
            c = int.Parse(values[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
