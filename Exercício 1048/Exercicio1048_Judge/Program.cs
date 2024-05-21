using System;
using System.Globalization;

namespace Exercicio1048_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1048
             *
             */

            double salario = 0.0, reajuste = 0.0, percentual = 0.0;

            salario = double.Parse(Console.ReadLine());

            if (salario <= 0.0)
            {
                Console.WriteLine("Não haverá aumento em seu salário.");
            }
            else if (salario > 0.0 && salario <= 400.00)
            {
                percentual = 15.0;
                reajuste = (salario * (percentual / 100));
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12.0;
                reajuste = (salario * (percentual / 100));
                salario += reajuste;

                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10.0;
                reajuste = (salario * (percentual / 100));
                salario += reajuste;

                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7.0;
                reajuste = (salario * (percentual / 100));
                salario += reajuste;

                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else
            {
                percentual = 4.0;
                reajuste = (salario * (percentual / 100));
                salario += reajuste;

                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
        }
    }
}
