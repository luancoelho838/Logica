Console.WriteLine("Maior de dois números!\n");

Console.WriteLine("Informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"O número {num1} é maior do que {num2}");
}
else if(num2 > num1)
{
        Console.WriteLine($"O número {num2} é maior do que {num1}");
}
else
{
        Console.WriteLine($"Os números são iguais");
}

