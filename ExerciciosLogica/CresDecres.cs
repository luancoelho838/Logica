Console.WriteLine("Digite dois números: ");
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());

while(num1 != num2)
{

    if (num1 > num2)
    {
        Console.WriteLine("Ordem decrescente!");
    }
    else
    {
        Console.WriteLine("Ordem crescente!");
    }

    Console.WriteLine("Digite outros dois números: ");
    num1 = double.Parse(Console.ReadLine());
    num2 = double.Parse(Console.ReadLine());
}