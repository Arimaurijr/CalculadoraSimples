double num1, num2;
int opcao = 0;

void Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch(opcao)
    {
        default:
            Console.WriteLine("Opção Inválida !");
            Console.ReadLine();
        break;

        case 1:
            Console.WriteLine("A soma dos números é: " + (num1 + num2));
            Console.ReadLine();
        break;

        case 2:
            Console.WriteLine("A subtração é : " +(num1 - num2));
            Console.ReadLine();
        break;

        case 3:
            Console.WriteLine("A Multiplicação  é : " + (num1 * num2));
            Console.ReadLine();
        break;

        case 4:
            Console.WriteLine("A divisão é :" + (num1 / num2));
            Console.ReadLine();
        break;

        case 5:
            Console.WriteLine("Até logo !");
            Console.ReadLine();
        break;
    }
}


Console.WriteLine("Informe o primeiro número");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número");
num2 = int.Parse(Console.ReadLine());   

while(opcao != 5)
{
    Menu();
}