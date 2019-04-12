using System;

namespace URI1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quotient, rest, note;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            rest = N;

            note = 100;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest = rest % note;

            note = 50;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest = rest % note;

            note = 20;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest = rest % note;

            note = 10;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest = rest % note;

            note = 5;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest = rest % note;

            note = 2;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest = rest % note;

            Console.WriteLine(rest + " nota(s) de R$ 1,00");
        }
    }
}
