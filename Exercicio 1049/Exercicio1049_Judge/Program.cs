namespace Exercicio1049_Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * https://judge.beecrowd.com/pt
             * 
             * Exercícío 1049
             *
             */

            string nome1, nome2, nome3;

            nome1 = Console.ReadLine();
            nome2 = Console.ReadLine();
            nome3 = Console.ReadLine();

            if (nome1 == "vertebrado")
            {
                if (nome2 == "ave")
                {
                    if (nome3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (nome3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (nome2 == "inseto")
                {
                    if (nome3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (nome3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}