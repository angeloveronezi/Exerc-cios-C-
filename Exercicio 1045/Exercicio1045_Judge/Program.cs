using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio1045_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercício 1045
             */
            string[] vet = Console.ReadLine().Split(" ");
            double a = 0.0, b = 0.0, c = 0.0, A = 0.00, B = 0.00, C = 0.00;

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (A > B && A > C)
            {
                a = A;
                if (B > C)
                {
                    b = B;
                    c = C;
                }
                else
                {
                    c = B;
                    C = b;
                }
            }
            else if (B > A && B > C)
            {
                a = B;
                if (A > C)
                {
                    b = A;
                    c = C;
                }
                else
                {
                    b = C;
                    c = B;
                }
            }
            else
            {
                a = C;
                if (A > C)
                {
                    b = A;
                    c = B;
                }
                else
                {
                    b = B;
                    c = A;
                }
            }


            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if ((a * a) == ((b * b) + (c * c)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if ((a * a) > ((b * b) + (c * c)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if ((a * a) < ((b * b) + (c * c)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }


            if (a == b && b == c && c == a)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}