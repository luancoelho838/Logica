    Console.WriteLine("Digite o código, quantidade e valor da peça 1:");
    string peca = Console.ReadLine();
    string[] peca1 = peca.Split(' ');

    int codigo = int.Parse(peca1[0]);
    int quantidade = int.Parse(peca1[1]);
    double valor = double.Parse(peca1[2]);

    Console.WriteLine("\nDigite o código, quantidade e valor da peça 2:");
    peca = Console.ReadLine();
    peca1 = peca.Split(' ');

    int codigo2 = int.Parse(peca1[0]);
    int quantidade2 = int.Parse(peca1[1]);
    double valor2 = double.Parse(peca1[2]);


    
    double total = (quantidade * valor) + (quantidade2 * valor2);


    Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");