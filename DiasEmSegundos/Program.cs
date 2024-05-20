using System;
using System.Globalization;


namespace DiasEmSegundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de dia(s): ");
            int valor = int.Parse(Console.ReadLine());

            int dia = (60 * 60 * 24) * valor;
            Console.WriteLine(valor + " dias em segundos: " + dia);
        }
    }
}
