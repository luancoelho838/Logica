Console.WriteLine("Funções!\n");

somar();
subtrair();
multiplicar();
dividir();

void somar()
{
    Console.Write("Digite o primeiro número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

     Console.WriteLine($"\nA soma de {num1} + {num2} é: {num1 + num2}\n");
}

void subtrair()
{
    Console.Write("Digite o primeiro número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

     Console.WriteLine($"\nA subtração de {num1} - {num2} é: {num1 - num2}\n");
}

void multiplicar()
{
    Console.Write("Digite o primeiro número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

     Console.WriteLine($"\nA multiplicação de {num1} * {num2} é: {num1 * num2}\n");
}

void dividir()
{
    Console.Write("Digite o primeiro número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

     if(num2 != 0)
     {
        Console.WriteLine($"\nA divisão de {num1} / {num2} é: {num1 / num2}\n");
     }
     else
     {
        Console.WriteLine("\nErro: Divisão por zero não é permitida.");
     }
}