using System;
using System.Globalization;

namespace Exercicio117_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1017
             * 
             */
            int tempo = int.Parse(Console.ReadLine());
            int km = int.Parse(Console.ReadLine());

            double total = (Convert.ToDouble(km) / 12) * tempo;

            Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
