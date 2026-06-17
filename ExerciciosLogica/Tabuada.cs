Console.WriteLine("Tabuada!");

Console.WriteLine("Informe um número para ver a tabuada:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"\nTabuada do número {numero}: \n");

for(int i = 1; i<=10; i++)
{
    int resultado = numero *i;
    Console.WriteLine($"{numero} X {i} = {resultado}");
}