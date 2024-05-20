using System;
using System.Globalization;

namespace Exercicio1006_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercício 1006
             */

            double A, B, C;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Exemplo:
            // Console.WriteLine("A = " + (A + 1).ToString("F3", CultureInfo.InvariantCulture));
            // Console.WriteLine("B = " + (B + 2).ToString("F2", CultureInfo.InvariantCulture));
            // Console.WriteLine("C = " + (C - 4).ToString("F1", CultureInfo.InvariantCulture));

            // Conta da primeira - Se 10.0 = 2 e 5.0 = 0,5 então regra de três (10 = 2 --- A = X)

            Console.WriteLine("MEDIA = " + (((A * 2) / 10) + ((B * 3) / 10) + ((C * 5) / 10)).ToString("F1", CultureInfo.InvariantCulture));

            
        }
    }
}
