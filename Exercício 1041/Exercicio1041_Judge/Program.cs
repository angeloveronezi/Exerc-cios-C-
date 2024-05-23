using System;
using System.Globalization;

namespace Exercicio1041_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercício 1041
             */
            string[] vet = Console.ReadLine().Split(" ");
            double x = 0.0, y = 0.0;
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0 && y > 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0.0 && y < 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0.0 && x > 0.00)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0 && x < 0.00)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("Q3");
            }
        }
    }
}