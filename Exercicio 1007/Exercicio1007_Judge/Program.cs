using System;
using System.Globalization;

namespace Exercicio1007_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1007
             * 
             */

            int A, B, C, D;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            Console.WriteLine("DIFERENCA = " + ((A * B) - (C * D)));
        }
    }
}
