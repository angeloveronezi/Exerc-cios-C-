using System;
using System.Globalization;

namespace Exercicio1051_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1051
             *
             */

            double renda = 0.0, imposto = 0.0;

            renda = double.Parse(Console.ReadLine());

            if (renda > 0.00 && renda < 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (renda > 2000.01 && < 3000.00)
            {

            }
        }
    }
}