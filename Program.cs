using System;

namespace CondicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            CondicionalSwitch();
        }

        private static void CondicionalSwitch()
        {
            Console.WriteLine("Informe o dia da semana de hoje\n");

            Console.WriteLine("1 - Segunda-feira");
            Console.WriteLine("2 - Terça-feira");
            Console.WriteLine("3 - Quarta-feira");
            Console.WriteLine("4 - Quinta-feira");
            Console.WriteLine("5 - Sexta-feira");
            Console.WriteLine("6 - Sabado");
            Console.WriteLine("7 - Domingo\n");

            string diaDaSemana = Console.ReadLine();

            switch (diaDaSemana)
            {
                case "1":
                    Console.WriteLine("\nHoje é: Segunda-feira");
                    break;
                case "2":
                    Console.WriteLine("\nHoje é: Terça-feira");
                    break;
                case "3":
                    Console.WriteLine("\nHoje é: Quarta-feira");
                    break;
                case "4":
                    Console.WriteLine("\nHoje é: Quinta-feira");
                    break;
                case "5":
                    Console.WriteLine("\nHoje é: Sexta-feira");
                    break;
                case "6":
                    Console.WriteLine("\nHoje é: Sabado");
                    break;
                case "7":
                    Console.WriteLine("\nHoje é: Domingo");
                    break;
                default:
                    Console.WriteLine("\nDia da semana invalido!");
                    break;
            }
        }

    }
}
