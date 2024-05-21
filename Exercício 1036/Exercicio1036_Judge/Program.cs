using System;
using System.Globalization;

namespace Exercicio1036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 1036
             * https://judge.beecrowd.com/pt
             * Realizando a fórmula de bhaskara referente a equação do segundo grau;
             *
             */

            string[] valores = Console.ReadLine().Split(" ");
            double A, B, C, delta;
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = Convert.ToDouble(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            delta = (Math.Pow(B, 2)) - (4 * A * C);
            if (A <= 0 || delta <= 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                delta = Math.Sqrt(delta);
                Console.WriteLine("R1 = " + (((-B) + delta) / (2 * A)).ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + (((-B) - delta) / (2 * A)).ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}