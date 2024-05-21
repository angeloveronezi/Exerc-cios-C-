using System;
using System.Globalization;

namespace Exercicio1038_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1038
             *
             */

            int codigo;
            double valor = 0.0;

            string[] vetor = Console.ReadLine().Split(" ");
            codigo = int.Parse(vetor[0]);
            valor = double.Parse(vetor[1]);

            switch (codigo)
            {
                case 1:
                    //Cachorro Quente - R$ 4,00
                    valor *= 4.0;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    //X-Salada - R$ 4,50
                    valor *= 4.5;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    //X-Bacon - R$ 5,00
                    valor *= 5.0;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    //Torrada Simples - R$ 2,00
                    valor *= 2.0;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    //Refrigerante - R$ 1,50
                    valor *= 1.5;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }

        }
    }
}
