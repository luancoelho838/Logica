int[] numero = new int [5];

for(int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("Digite um número: ");
    numero[i] = int.Parse(Console.ReadLine());
}

Array.Reverse(numero);

Console.WriteLine("Valores invertido: ");
for(int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"{numero[i]}");
}


/* Percorrendo o array de trás para frente

int[] numero = new int [5];

for(int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("Digite um número: ");
    numero[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Valores invertidos: ");
for(int i = numero.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{numero[i]}");
}

*/