using System;
using System.Globalization;

namespace Exercicio1021
{
   internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * Exercícío 1021
             */

            //Console.WriteLine("Digite Nome e SobreNome: ");
            //string[] NomeSobreNome = Console.ReadLine().Split(' ');
            //string Nome = NomeSobreNome[0];
            //string SobreNome = NomeSobreNome[1];

            //Console.WriteLine("Digite um valor com duas casas decimais");
            double valor, valorRestante, contaMoedas, moeda1, moeda050, moeda025, moeda010, moeda05, moeda01;
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            valor = valor;
            int nota100, nota50, nota20, nota10, nota5, nota2, resto;

            nota100 = (int)valor / 100;
            resto = (int)valor % 100;
            valorRestante = valor - (nota100 * 100);

            nota50 = resto / 50;
            resto = resto % 50;
            valorRestante = valorRestante - (nota50 * 50);

            nota20 = resto / 20;
            resto = resto % 20;
            valorRestante = valorRestante - (nota20 * 20);

            nota10 = resto / 10;
            resto = resto % 10;
            valorRestante = valorRestante - (nota10 * 10);

            nota5 = resto / 5;
            resto = resto % 5;
            valorRestante = valorRestante - (nota5 * 5);

            nota2 = resto / 2;
            resto = resto % 2;
            valorRestante = valorRestante - (nota2 * 2);

            moeda1 = resto / 1;
            valorRestante = valorRestante - (moeda1 * 1);


            /*
             *    100 - 1
             *     x  - 0,73
             *      = 730
             *     730 / 1000 = 0,73
             */

            resto = (resto * 100);   //Necessário converter notas para moedas;
            contaMoedas = resto * valorRestante;
            contaMoedas = Math.Round(contaMoedas, 2);
            moeda050 = contaMoedas / 50;        // (0.50f * 100) ou faz o cálculo com 50 ou converte centavos em real;
            moeda050 = Math.Round(moeda050, 2);
            valorRestante = Math.Round(valorRestante, 2);
            valorRestante = Math.Round(((contaMoedas % 50) - valorRestante / 100), 2);
            valorRestante = Math.Round((valorRestante / 100), 2);


            contaMoedas = valorRestante * resto;
            contaMoedas = Math.Round(contaMoedas, 2);
            moeda025 = contaMoedas / 25;
            moeda025 = Math.Round(moeda025, 2);
            valorRestante = Math.Round(valorRestante, 2);
            valorRestante = Math.Round((((contaMoedas % 25) - valorRestante) / 100), 2);


            contaMoedas = valorRestante * resto;
            contaMoedas = Math.Round(contaMoedas, 2);
            moeda010 = contaMoedas / 10;
            moeda010 = Math.Round(moeda010, 2);
            valorRestante = Math.Round(valorRestante, 2);
            valorRestante = Math.Round((((contaMoedas % 10) - valorRestante) / 100), 2);


            contaMoedas = valorRestante * resto;
            contaMoedas = Math.Round(contaMoedas, 2);
            moeda05 = contaMoedas / 5;
            moeda05 = Math.Round(moeda05, 2);
            valorRestante = Math.Round(valorRestante, 2);
            valorRestante = Math.Round((((contaMoedas % 5) - valorRestante) / 100), 2);


            contaMoedas = valorRestante * resto;
            contaMoedas = Math.Round(contaMoedas, 2);
            moeda01 = contaMoedas / 1;
            moeda01 = Math.Round(moeda01, 2);
            valorRestante = Math.Round(valorRestante, 2);
            valorRestante = Math.Round((((contaMoedas % 1) - valorRestante) / 100), 2);


            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("MOEDAS: ");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine((int)moeda050 + " moeda(s) de R$ 0.50");
            Console.WriteLine((int)moeda025 + " moeda(s) de R$ 0.25");
            Console.WriteLine((int)moeda010 + " moeda(s) de R$ 0.10");
            Console.WriteLine((int)moeda05 + " moeda(s) de R$ 0.05");
            Console.WriteLine((int)moeda01 + " moeda(s) de R$ 0.01");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}