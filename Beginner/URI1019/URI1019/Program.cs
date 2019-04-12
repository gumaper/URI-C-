using System;

namespace URI1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, rest, hours, minutes, seconds;

            N = int.Parse(Console.ReadLine());

            hours = N / 3600;
            rest = N % 3600;
            minutes = rest / 60;
            seconds = rest % 60;

            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
    }
}
