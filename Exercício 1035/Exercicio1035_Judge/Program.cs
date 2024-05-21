using System;
using System.Globalization;


namespace Exercicio1035_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * https://judge.beecrowd.com/pt
            * 
            * Exercícío 1035
            *
            */
            
            int A, B, C, D, X;
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);
            X = A % 2;

            if ((A >= 0) && (B >= 0) && (C >= 0) && (D >= 0))
            {
                if (B > C)
                {
                    Console.WriteLine("Valores aceitos");
                }
                else if (B > C)
                {
                    Console.WriteLine("Valores aceitos");
                }
                else if ((C + D) > (A + B + C + D))
                {
                    Console.WriteLine("Valores aceitos");
                }
                else if (X == 0)
                {
                    Console.WriteLine("Valores aceitos");
                }
                else
                {
                    Console.WriteLine("Valores nao aceitos");
                }
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
