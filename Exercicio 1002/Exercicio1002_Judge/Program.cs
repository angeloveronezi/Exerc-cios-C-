using System;
using System.Globalization;

namespace Exercicio1002_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1002
             * 
             * A fórmula para calcular a área de uma cirgunferência é: area = n . raio².
             * Considerando para este problema que n = 3.14159:
             * - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por n.
             * 
             * ENTRADA:
             * A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
             * 
             * SAÍDA:
             * Apresentar a mensagem "A=" seguindo pelo valor da variável area, conforme exemplo abaixo,
             * com 4 casas após o ponto decimal. Utilize variáveis de dupla precisão (double). Como todos
             * os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
             * 
             *  --------------------------------
             * |  Ex. Entrada   |  Ex. Saída    |
             * |     2.00       |  A=12.5664    |
             * |                |               |
             * |   100.64       |  A=31819.3103 |
             * |                |               |
             * |   150.00       |  A=70685.7750 |
             *  -------------------------------- 
             * 
             */

            double area, n, raio;
            n = 3.14159;
            raio = double.Parse(Console.ReadLine());
            area = n * (Math.Pow(raio, 2));

            Console.WriteLine("A=" + area.ToString("F0", CultureInfo.InvariantCulture));
        }
    }
}
