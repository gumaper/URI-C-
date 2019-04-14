using System;

namespace URI1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] values = Console.ReadLine().Split(' ');

            A = int.Parse(values[0]);
            B = int.Parse(values[1]);
            C = int.Parse(values[2]);
            D = int.Parse(values[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
