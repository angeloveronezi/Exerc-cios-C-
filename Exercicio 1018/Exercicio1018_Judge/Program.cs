using System;
using System.Globalization;

namespace Exercicio1018_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1018
             * 
             */

            //Console.WriteLine(576 / 100); // = 5
            //Console.WriteLine(576 % 100); // = 76
            //Console.WriteLine(76 / 50);  // = 1
            //Console.WriteLine(76 % 50); // = 26

            int valor = int.Parse(Console.ReadLine());

            int notas100, notas50, notas20, notas10, notas5, notas2, notas1, resta;
            
            notas100 = valor / 100;
            resta = valor % 100;
            
            notas50 = resta / 50;
            resta = resta % 50;

            notas20 = resta / 20;
            resta = resta % 20;

            notas10 = resta / 10;
            resta = resta % 10;

            notas5 = resta / 5;
            resta = resta % 5;

            notas2 = resta / 2;
            resta = resta % 2;

            notas1 = resta / 1;
            resta = resta % 1;

            //Console.WriteLine("Valor: " + valor);
            //Console.WriteLine("Resta: " + resta);
            Console.WriteLine(valor);
            Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2,00");
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");
        }
    }
}
