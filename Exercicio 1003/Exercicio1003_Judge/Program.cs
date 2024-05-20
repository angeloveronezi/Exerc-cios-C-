using System;
using System.Globalization;

namespace Exercicio1003_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1003
             * 
             * Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre
             * elas e atribua á variável SOMA. A seguir escrever o valor desta variável.
             * 
             * ENTRADA:
             * O arquivo de entrada contém 2 valores inteiros.
             * 
             * SAÍDA:
             * Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes
             * e depois da igualdade seguido pelo valor correspondente á soma de A e B. Como todos os 
             * problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você
             * receberá "Presentation Error".
             * 
             * 
             *  ----------------------------
             * | Ex. Entrada  | Ex. Saída   |
             * |    30        |             |
             * |    10        | SOMA = 40   |
             * |              |             |
             * |   -30        |             |
             * |    10        | SOMA = -20  |
             * |              |             |
             * |     0        |             |
             * |     0        | SOMA = 0    |
             *  ----------------------------
             * 
             */

            int A, B, SOMA;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);

        }
    }
}
