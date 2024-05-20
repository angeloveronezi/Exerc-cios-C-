using System;
using System.Globalization;

namespace Exercicio1009_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1009
             * 
             */

            string NomeFunc = "";
            double SalarioFixo, TotalVendas, TotalSalario;

            NomeFunc = Console.ReadLine();
            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TotalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TotalSalario = SalarioFixo + (TotalVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + TotalSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
