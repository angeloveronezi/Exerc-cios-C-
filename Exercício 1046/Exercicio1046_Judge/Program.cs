using System;
using System.Globalization;


namespace Exercicio1046_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1046
             *
             */
            int hora1, hora2;
            string[] vetor = Console.ReadLine().Split(' ');

            hora1 = int.Parse(vetor[0]);
            hora2 = int.Parse(vetor[1]);

            if (hora1 > hora2)
            {
                if (hora1 < 24)
                {
                    hora1 = 24 - hora1;
                    Console.WriteLine("O JOGO DUROU " + (hora1 + hora2) + " HORA(S)");
                }
                else
                {
                    Console.WriteLine("VERIFICAR A LÓGICA DO PROGRAMA!!");
                }
            }
            else
            {
                if (hora1 - hora2 == 0)
                {
                    hora1 = 24;
                    Console.WriteLine("O JOGO DUROU " + hora1 + " HORA(S)");
                }
                else
                {
                    Console.WriteLine("O JOGO DUROU " + (hora2 - hora1) + " HORA(S)");
                }
            }
        }
    }
}
