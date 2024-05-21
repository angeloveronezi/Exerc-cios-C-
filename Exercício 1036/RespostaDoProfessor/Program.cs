using System;
using System.Globalization;

namespace RespostaDoProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, r1, r2;

            ////A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ////B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ////C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            String[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2) - 4 * A * C;

            if (A == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                r1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                r2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture);
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture);
            }
        }
    }
}
