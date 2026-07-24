int[] notas = new int[10];

for(int i= 0; i < notas.Length; i++)
{
    Console.WriteLine("Digite uma nota: ");
    notas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Média das notas: {notas.Average()}");
Console.WriteLine($"Maior nota: {notas.Max()}");
Console.WriteLine($"Menor nota: {notas.Min()}");



