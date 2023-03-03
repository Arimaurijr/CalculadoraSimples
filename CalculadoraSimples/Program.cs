using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        double numero_1 = 0.0, numero_2 = 0.0;
        double divisao = 0.0;

        Console.WriteLine("Digite o primeiro número");
        numero_1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o segundo número");
        numero_2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("A SOMA ENTRE O " + numero_1 + " E " + numero_2 + " = " + (numero_1 + numero_2));

        Console.WriteLine("SUBTRAÇÕES");
        Console.WriteLine("A SUBTRAÇÃO ENTRE O " + numero_1 + " E " + numero_2 + " = " + (numero_1 - numero_2));
        Console.WriteLine("A SUBTRAÇÃO ENTRE O " + numero_2 + " E " + numero_1 + " = " + (numero_2 - numero_1));

        Console.WriteLine("A MULTIPLICAÇÃO ENTRE O " + numero_1 + " E " + numero_2 + " = " + (numero_1 * numero_2));

        if (numero_2 != 0.0)
        {
            divisao = numero_1 / numero_2;
            Console.WriteLine("A DIVISÃO ENTE O " + numero_1 + " E " + numero_2 + " = " + divisao.ToString("F2", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("NÃO É POSSÍVEL DIVIDIR POR ZERO");
        }

    }
}