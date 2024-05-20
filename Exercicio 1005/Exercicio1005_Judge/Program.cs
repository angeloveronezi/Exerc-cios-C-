using System;
using System.Globalization;

namespace Exercicio1005_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1005
             * 
             */

            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = (A * (3.5 / 11)) + (B * (7.5 / 11));
            //Utilizado 11 pois o peso é total é 11 (3.5 + 7.5)
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
