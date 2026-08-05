Console.WriteLine("Quantos números serão digitados? ");
int N = int.Parse(Console.ReadLine());
double[] numeros = new double[N];

for(int i = 0; i < N; i++)
{
    Console.WriteLine($"Digite o {i+1}° número: ");
    numeros[i] = double.Parse(Console.ReadLine());
}


Console.Write("Os números digitados foram: ");
for(int i = 0; i < N; i++)
{
    Console.Write($"{numeros[i]} ");
}
Console.WriteLine();
Console.WriteLine($"A soma dos números digitados é: {numeros.Sum()}");
Console.WriteLine($"A média dos números digitados é: {numeros.Average()}");