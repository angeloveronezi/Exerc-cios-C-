using System;
using System.Globalization;

namespace Exercicio1004_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1004
             * 
             */

            int x, y, PROD;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            PROD = x * y;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
