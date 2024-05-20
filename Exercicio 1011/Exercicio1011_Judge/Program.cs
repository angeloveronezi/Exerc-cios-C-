using System;
using System.Globalization;


namespace Exercicio1011_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1011
             * 
             */
            double pi = 3.14159;
            double formulaRaio = (4.0 / 3.0) * pi;
            float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("VOLUME = " + (formulaRaio * (Math.Pow(raio, 3))).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
