using System;
using System.Globalization;

namespace Exercicio1040_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1040
             *
             */
            string[] vetor = Console.ReadLine().Split(" ");
            float nota1 = 0.0f
                , nota2 = 0.0f
                , nota3 = 0.0f
                , nota4 = 0.0f
                , total = 0.0f
                , media = 0.0f
                , exame = 0.0f;

            nota1 = float.Parse(vetor[0]);
            nota2 = float.Parse(vetor[1]);
            nota3 = float.Parse(vetor[2]);
            nota4 = float.Parse(vetor[3]);

            nota1 = (nota1 * 2f) / 10f;
            nota2 = (nota2 * 3f) / 10f;
            nota3 = (nota3 * 4f) / 10f;
            nota4 = (nota4 * 1f) / 10f;
            media = (nota1 + nota2 + nota3 + nota4);

            if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");

                exame = float.Parse(Console.ReadLine());
                media = (media + exame) / 2;
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno Reprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
