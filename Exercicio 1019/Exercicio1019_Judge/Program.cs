using System;
using System.Globalization;

namespace Exercicio1019_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1019
             *
             *          1 min = 60 seg
             * 1 hor = 60 min = 3600 seg
             */

            int N, horas, resto, minutos, segundos;
            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
