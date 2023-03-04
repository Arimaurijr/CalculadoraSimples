
internal class Program
{
    private static void Main(string[] args)
    {
        int opcao = 0;
        int numero1 = 0, numero2 = 0;

        int Menu()
        {
            Console.WriteLine("1 - Somar dois números");
            Console.WriteLine("2 - Subtrair dois números");
            Console.WriteLine("3 - Multiplicar dois números");
            Console.WriteLine("4 - Dividir dois núemros");
            Console.WriteLine("5 - sair");
            opcao = int.Parse(Console.ReadLine());

            return opcao;
        }

        void Somar(int numero1, int numero2)
        {
            Console.WriteLine("A soma entre o " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
        }
        void Subtrair(int numero1, int numero2)
        {
            Console.WriteLine("A subtração entre o " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
        }
        void Multiplicacao(int numero1, int numero2)
        {
            Console.WriteLine("A multiplicação entre o " + numero1 + " * " + numero2 + " = " + (numero1 * numero2));
        }
        void Divisao(int numero1, int numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Não é possivel dividir por zero");
            }
            else
            {
                double divisao = (double)numero1 / numero2;
                Console.WriteLine("A divisão entre o " + numero1 + " / " + numero2 + " = " + divisao.ToString("F2"));
            }
        }
        void MensagemAteLogo()
        {
            Console.WriteLine("Até logo !!!");
        }
        void OpcaoInvalida()
        {
            Console.WriteLine("Opção inválida !!!");
        }

        void escolha(int opcao, int numero1, int numero2)
        {
            switch (opcao)
            {
                case 1:
                    Somar(numero1, numero2);
                    break;

                case 2:
                    Subtrair(numero1, numero2);
                    break;

                case 3:
                    Multiplicacao(numero1, numero2);
                    break;

                case 4:
                    Divisao(numero1, numero2);
                    break;

                case 5:
                    MensagemAteLogo();
                    break;

                default:
                    OpcaoInvalida();
                    break;

            }
        }

        int PegarNumero(int i)
        {
            int numero;
            Console.WriteLine("Digite o " + i + "º número: ");
            numero = int.Parse(Console.ReadLine());
            return numero;
        }

        numero1 = PegarNumero(1);
        numero2 = PegarNumero(2);

        while (opcao != 5)
        {

            opcao = Menu();
            escolha(opcao, numero1, numero2);

        }

    }
}