using System;
using System.Globalization;

namespace Exercicio1010_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1010
             * 
             */

            string[] pecas_1 = Console.ReadLine().Split(' ');
            string[] pecas_2 = Console.ReadLine().Split(' ');

            int CodPecas_1 = int.Parse(pecas_1[0]);
            int QuantidadePecas_1 = int.Parse(pecas_1[1]);
            double ValorPecas_1 = double.Parse(pecas_1[2], CultureInfo.InvariantCulture);
            
            double TotalPagarPecas_1 = QuantidadePecas_1 * ValorPecas_1;


            int CodPecas_2 = int.Parse(pecas_2[0]);
            int QuantidadePecas_2 = int.Parse(pecas_2[1]);
            double ValorPecas_2 = double.Parse(pecas_2[2], CultureInfo.InvariantCulture);

            double TotalPagarPecas_2 = QuantidadePecas_2 * ValorPecas_2;

            Console.WriteLine("VALOR A PAGAR: R$ " + (TotalPagarPecas_1 + TotalPagarPecas_2).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
