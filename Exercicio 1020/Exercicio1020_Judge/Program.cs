using System;
using System.Globalization;

namespace Exercicio1020_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1020
             *
             */

            int idade, ano, mes, dia, resto;

            idade = int.Parse(Console.ReadLine());
            ano = idade / 365;
            resto = idade % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");


              //----------------------------------------------------\\
             //------------------------------------------------------\\
            //-------------              OU              -------------\\  
           //----------------------------------------------------------\\
          //------------------------------------------------------------\\

            int valor, calculo, resta;
            valor = int.Parse(Console.ReadLine());
            calculo = valor / 365;
            resta = valor % 365;
            Console.WriteLine(calculo + " ano(s)");

            calculo = resto / 30;
            resta = resto % 30;
            Console.WriteLine(calculo + " mes(es)");
            Console.WriteLine(resta + " dia(s)");



        }
    }
}