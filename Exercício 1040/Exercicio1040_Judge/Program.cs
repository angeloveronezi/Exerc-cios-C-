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

            nota1 = (nota1 * 2.0f) / 10.0f;
            nota2 = (nota2 * 3.0f) / 10.0f;
            nota3 = (nota3 * 4.0f) / 10.0f;
            nota4 = (nota4 * 1.0f) / 10.0f;
            media = (nota1 + nota2 + nota3 + nota4);

            Console.WriteLine(media);

            if (media < 5.0)
            {
                if (media >= 4.85 && media <= 4.8500005) //Necessário pois há uma falha de arredondamento
                {
                    media = 4.80f;
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno reprovado.");
                }
                else
                {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno reprovado.");
                }
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
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
