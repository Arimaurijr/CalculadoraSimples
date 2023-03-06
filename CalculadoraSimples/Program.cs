using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double numero1 = 0.0, numero2 = 0.0;
        int opcao;

        int Menu()
        {
            Console.WriteLine("1 - SOMAR");
            Console.WriteLine("2 - SUBTRAIR");
            Console.WriteLine("3 - MULTIPLICAR");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("5 - SAIR");

            return opcao = int.Parse(Console.ReadLine());
        }

        double Somar()
        {
            return numero1 + numero2;
        }
        double Subtrair()
        {
            return numero1 - numero2;
        }
        double Multiplicacao()
        {
            return numero1 * numero2;
        }
        double Divisao()
        {
            return numero1 / numero2;
        }

        while (Menu() != 5)
        {
            Console.WriteLine("DIGITE O NUMERADOR:");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O DENOMINADOR: ");
            numero2 = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("A SOMA ENTRE OS NÚMEROS É " + Somar());
                    break;

                case 2:
                    Console.WriteLine("A SUBTRAÇÃO ENTRE OS NÚMEROS É " + Subtrair());
                    break;

                case 3:
                    Console.WriteLine("A MULTIPLICAÇÃO ENTRE OS NÚMEROS É " + Multiplicacao());
                    break;

                case 4:
                    if (numero2 == 0.0)
                    {
                        Console.WriteLine("DENOMINADOR IGUAL A ZERO");
                    }
                    else
                    {
                        Console.WriteLine("A DIVISÃO ENTRE O NÚMEROS É " + numero1 / numero2);
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida !");
                    break;
            }
        }

        Console.WriteLine("Até logo !");

    }
}