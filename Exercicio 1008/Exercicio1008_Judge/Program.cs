using System;
using System.Globalization;

namespace Exercicio1008_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1008
             * 
             */

            int codFuncionario, horaTrabalhada;
            double recebeHora;
            codFuncionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horaTrabalhada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            recebeHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER = " + codFuncionario);
            Console.WriteLine("SALARY = U$ " + (horaTrabalhada * recebeHora).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
