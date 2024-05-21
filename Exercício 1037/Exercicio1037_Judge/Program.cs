using System;
using System.Globalization;

namespace Exercicio1037_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1037
             *
             */

            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0.250 && valor <= 25.000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor >= 25.0001 && valor <= 50.000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor >= 50.001 && valor <= 75.000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor >= 75.001 && valor <= 100.000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
