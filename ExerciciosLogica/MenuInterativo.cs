Console.WriteLine("Menu Interativo!\n");

int opcao = 0;

while(opcao != 5)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Opção 1");
    Console.WriteLine("2 - Opção 2");
    Console.WriteLine("3 - Opção 3");
    Console.WriteLine("4 - Opção 4");
    Console.WriteLine("5 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch(opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu a Opção 1!");
            break;
        case 2:
            Console.WriteLine("Você escolheu a Opção 2!");
            break;
        case 3:
            Console.WriteLine("Você escolheu a Opção 3!");
            break;
        case 4:
            Console.WriteLine("Você escolheu a Opção 4!");
            break;
        case 5:
            Console.WriteLine("Saindo do menu. Até mais!");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }

    Console.WriteLine(); 
}




