int[] notas = new int[10];

for(int i= 0; i < notas.Length; i++)
{
    Console.WriteLine("Digite uma nota: ");
    notas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Notas digitadas: ");
for(int i = 0; i < notas.Length; i++)
{
    Console.WriteLine(notas[i]);
}
