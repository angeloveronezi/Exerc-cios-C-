using System;
using System.Globalization;

namespace Exercicio1015_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1015
             * 
             */

            string[] StrP1, StrP2;
            StrP1 = Console.ReadLine().Split(' ');
            StrP2 = Console.ReadLine().Split(' ');

            float x1 = float.Parse(StrP1[0], CultureInfo.InvariantCulture);
            float y1 = float.Parse(StrP1[1], CultureInfo.InvariantCulture);

            float x2 = float.Parse(StrP2[0], CultureInfo.InvariantCulture);
            float y2 = float.Parse(StrP2[1], CultureInfo.InvariantCulture);

           /*
            * Fiz apenas para ir verificando se os cálculos estavam corretos;
            * 
            * double Potencia1 = Math.Pow((x2-x1), 2);
            * double Potencia2 = Math.Pow((y2-y1), 2);
            * double calc = Math.Sqrt((Potencia1 + Potencia2));
            *
            * Console.WriteLine(Potencia1.ToString("F4", CultureInfo.InvariantCulture) + " - " + Potencia2.ToString("F4", CultureInfo.InvariantCulture) + " - " + calc.ToString("F4", CultureInfo.InvariantCulture));
            */

            Console.WriteLine((Math.Sqrt((Math.Pow((x2 - x1), 2) + (Math.Pow((y2-y1), 2))))).ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
