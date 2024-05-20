using System;
using System.Globalization;


namespace Exercicio1012_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1012
             * 
             */
            float A, B, C;
            double pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');
            A = float.Parse(valores[0], CultureInfo.InvariantCulture);
            B = float.Parse(valores[1], CultureInfo.InvariantCulture);
            C = float.Parse(valores[2], CultureInfo.InvariantCulture);

            //Base x Altura ÷ 2
            Console.WriteLine("TRIANGULO: " + ((A * C)/2).ToString("F3", CultureInfo.InvariantCulture));

            //A = π.r²
            Console.WriteLine("CIRCULO: " + (pi * Math.Pow(C, 2)).ToString("F3", CultureInfo.InvariantCulture));

            //A=(a+b).h/2
            Console.WriteLine("TRAPEZIO: " + (((A + B) * C)/2).ToString("F3", CultureInfo.InvariantCulture));

            //A=L²
            Console.WriteLine("QUADRADO: " + (Math.Pow(B,2)).ToString("F3", CultureInfo.InvariantCulture));

            //A=b⋅h
            Console.WriteLine("RETANGULO: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
