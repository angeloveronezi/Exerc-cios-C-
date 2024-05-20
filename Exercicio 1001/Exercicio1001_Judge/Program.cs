using System;
using System.Globalization;

namespace Exercicio1001_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Barra de Menu superior - Problemas - Todos - Iniciante;
             * 
             * Exercícío 1001
             * 
             * Leia 2 valores inteiros e armazene-os nas viariáveis A e B. Efetue a soma de A e B atribuindo
             * o seu resultado na variáveis X. Imprima X conforme exemplo apresentado abaixo. Não apresente mensagem
             * alguma além daquilo que está sendo especificado e não esqueça de imprimir o fim de linha após o resultado,
             * caso contrário, você receberá "Presentation Error".
             * 
             * ENTRADA:
             * A entrada contém 2 valores inteiros.
             * 
             * SAÍDA:
             * Imprima a variável X conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
             * Obs.: O X está em maiúsculo e deve ter um espaço antes e um espaço depois do sinal de igualdade.
             * 
             * 
             *  ---------------------------------------------
             * |  Ex. Entrada           |     Ex. Saída      |
             * |      10                |                    |
             * |       9                |       X = 19       |
             * |                        |                    |
             * |     -10                |                    |
             * |       4                |       X = -6       |
             * |                        |                    |
             * |      15                |                    |
             * |      -7                |       X =  8       |
             *  ---------------------------------------------
             * 
             */

            int A, B, X;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            X = A + B;
            Console.WriteLine("X = " + X);

            Console.ReadLine();
        }
    }
}
