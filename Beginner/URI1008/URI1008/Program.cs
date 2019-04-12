using System;
using System.Globalization;

namespace URI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int employe, hours;
            double salaryPerHour, salary;

            employe = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            salaryPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = hours * salaryPerHour;

            Console.WriteLine("NUMBER = " + employe);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
