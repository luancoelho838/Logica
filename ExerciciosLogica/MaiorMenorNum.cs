int Numero = 0;

int Maior = Numero;
int Menor = Numero;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número: ");
    Numero = int.Parse(Console.ReadLine());
    if(Numero > Maior)
    {
        Maior = Numero;
    }
    if(Numero < Menor)
    {
        Menor = Numero;
    }
}

Console.WriteLine($"Maior número: {Maior}");
Console.WriteLine($"Menor número: {Menor}");