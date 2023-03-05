
internal class Program
{
    private static void Main(string[] args)
    {
        double numero1 = 0.0, numero2 = 0.0, resultado = 0.0;
        int opcao, ordem = 1;
        string operacao;

        void Menu()
        {
            Console.WriteLine("1 - SOMAR DOIS NÚMEROS");
            Console.WriteLine("2 - SUBTRAIR DOIS NÚMEROS");
            Console.WriteLine("3 - MULTIPLICAR DOIS NÚMEROS");
            Console.WriteLine("4 - DIVIDIR DOIS NÚMEROS");
            Console.WriteLine("5 - TROCAR NÚMEROS ENTRE SI");
            Console.WriteLine("6 - ENTRAR COM NOVOS VALORES");
            Console.WriteLine("7 - SAIR");
            opcao = int.Parse(Console.ReadLine());
        }

        void Entrada()
        {
            if (ordem > 2)
            {
                ordem = 1;
            }

            Console.WriteLine("ENTRE COM " + ordem + " º VALOR");
            if (ordem == 1)
            {
                numero1 = int.Parse(Console.ReadLine());
            }
            else
            {
                numero2 = int.Parse(Console.ReadLine());
            }
            ordem++;
        }
        void saida()
        {
            Console.WriteLine("Até logo !!!");
        }
        void Erro()
        {
            Console.WriteLine("Opção inválida !!!");
        }

        void MostrarTela()
        {
            Console.WriteLine(operacao + " entre " + numero1 + " e " + numero2 + " = " + resultado);
        }

        void Somar()
        {
            resultado = numero1 + numero2;
            operacao = "SOMA";
            MostrarTela();
        }
        void Subtrair()
        {
            resultado = numero1 - numero2;
            operacao = "SUBTRAÇÃO";
            MostrarTela();
        }
        void Multiplicar()
        {
            resultado = numero1 * numero2;
            operacao = "MULTIPLICAÇÃO";
            MostrarTela();
        }
        void dividir()
        {
            if (numero2 == 0.0)
            {
                Console.WriteLine("NÃO É POSSÍVEL DIVIDIR POR ZERO !!!");
            }
            else
            {
                resultado = (numero1 / numero2);
                operacao = "DIVISÃO";
                MostrarTela();
            }
        }
        void Trocar()
        {
            double aux;
            aux = numero1;
            numero1 = numero2;
            numero2 = aux;
        }
        void Mudar()
        {
            for (int i = 1; i <= 2; i++)
            {
                Entrada();
            }
        }

        void Escolha()
        {
            switch (opcao)
            {
                case 1:
                    Somar();
                    break;

                case 2:
                    Subtrair();
                    break;

                case 3:
                    Multiplicar();
                    break;

                case 4:
                    dividir();
                    break;

                case 5:
                    Trocar();
                    break;

                case 6:
                    Mudar();
                    break;

                case 7:
                    saida();
                    break;

                default:
                    Erro();
                    break;

            }
        }

        for (int i = 1; i <= 2; i++)
        {
            Entrada();
        }

        Console.WriteLine();
        Menu();
        Console.WriteLine();
        while (opcao != 7)
        {
            Escolha();
            Menu();
            Console.WriteLine();
        }
    }
}