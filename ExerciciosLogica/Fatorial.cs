Console.WriteLine("Digite um número para calcular o fatorial:");
int numero = int.Parse(Console.ReadLine());

for(int i = 0; i <= numero; i++)
{
    int fatorial = 1;

    for(int j = 1; j <= i; j++)
    {
        fatorial *= j;
    }

    Console.WriteLine($"O fatorial de {i} é: {fatorial}");
}
