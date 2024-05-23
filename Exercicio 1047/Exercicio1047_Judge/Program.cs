using System;
using System.Globalization;

namespace Exercicio1047_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1047
             *
             */

            int h1, h2, min1, min2;
            string[] vet = Console.ReadLine().Split(" ");

            h1 = int.Parse(vet[0]);
            min1 = int.Parse(vet[1]);
            h2 = int.Parse(vet[2]);
            min2 = int.Parse(vet[3]);

            //Transformando horas em minutos
            h1 *= 60;
            h2 *= 60;

            //Somando os minutos em horas
            h1 += min1;
            h2 += min2;

            if (h2 - h1 == 0)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA (S) E 0 MINUTO (S)");
            }
            else if (h2 - h1 < 60)
            {
                Console.WriteLine("O JOGO DUROU 0 HORA (S) E " + (h2 - h1) + " MINUTO (S)");
            }
            else
            {
                int total = h2 - h1;
                int resto = total % 60;
                Console.WriteLine("O JOGO DUROU " + resto + " HORA (S) E " + ((total - resto) / 60) + " MINUTO (S)");
            }
        }
    }
}