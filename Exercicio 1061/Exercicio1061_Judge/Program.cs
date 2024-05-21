using System;
using System.Globalization;

namespace Exercicio1061_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * -- Precisa melhorar o Código pois se o horário for maior que 24 soma um no dia e assim por diante;
             * -- inclusive precisa validar se o valor recebido em dia na segunda vez é maior do que o primeiro
             * 
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1061
             *
             * W = dia
             * X = hora
             * Y = minuto
             * Z = segundo
             */

            int W, X, Y, Z;
            string[] p1 = Console.ReadLine().Split(" ");
            string[] p2 = Console.ReadLine().Split(" : ");
            
            string[] p3 = Console.ReadLine().Split(" ");
            string[] p4 = Console.ReadLine().Split(" : ");

            W = ((int.Parse(p1[1]) * 24) + int.Parse(p2[0])) - ((int.Parse(p3[1]) * 24) + int.Parse(p4[0]));
            if (W < 0)
            {
                W = (W * (-1) / 24);
            }
            else
            {
                W = W / 24;
            }

            X = (24 - int.Parse(p2[0]))  - (24 - int.Parse(p4[0]));
            if (X < 0)
            {
                X = (X * (-1));
                X = 24 - X;
            }
            else
            {
                X = 24 - X;
            }

            Y = int.Parse(p2[1]) - int.Parse(p4[1]);
            if(Y < 0)
            {
                Y = Y * (-1);

            }


            Z = int.Parse(p2[2]) - int.Parse(p4[2]);
            if(Z < 0)
            {
                Z = Z * (-1);
            }

            Console.WriteLine(W + " dia (s)");
            Console.WriteLine(X + " hora (s)");
            Console.WriteLine(Y + " minuto (s)");
            Console.WriteLine(Z + " segundo (s)");
        }
    }
}
