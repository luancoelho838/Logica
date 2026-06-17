Console.WriteLine("Contador de números pares!\n");

Console.WriteLine("Informe um número inteiro:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"Os números pares de 0 até {numero} são:");

for(int i = 1; i <= numero; i++)
{if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}