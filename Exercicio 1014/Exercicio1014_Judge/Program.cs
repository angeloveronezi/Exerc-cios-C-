using System;
using System.Globalization;

namespace Exercicio1014_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1014
             * 
             */
            int X = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine((X/Y).ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
