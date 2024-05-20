using System;
using System.Globalization;
using System.Net.Quic;

namespace Exercicio1013_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1013
             * 
             */
            string[] valores = Console.ReadLine().Split(' ');

            int a, b, c, MaiorAB, MaiorABC;
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c= int.Parse(valores[2]);

            MaiorAB = ((a + b + Math.Abs(a-b)) /2);
            MaiorABC = ((MaiorAB + c + Math.Abs(MaiorAB-c)) /2);

            Console.WriteLine(MaiorABC + " eh o maior");
        }
    }
}
