Console.WriteLine("Digite dois números: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int troca;
int soma = 0;

if(x > y){
    troca = x;
    x = y;
    y = troca;
}


for(int i = x+1; i < y; i++)
{
    if(i % 2 != 0)
    {
        soma = soma + i;
    }
}

Console.WriteLine($"A soma dos números ímpares entre {x} e {y} é: {soma}");