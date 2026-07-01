
Console.WriteLine("Esse programa irá somar os números digitados até o usuário digitar '0'!\n");


    Console.WriteLine("Digite um número: ");
    int num = int.Parse(Console.ReadLine());

    int soma = 0;
    int contador = 0;


while(num != 0)
{
    contador++;
    soma += num;
    Console.WriteLine("Digite outro número: ");
    num = int.Parse(Console.ReadLine());

}

    Console.WriteLine($"A soma dos números é: {soma}");
    Console.WriteLine($"Quantidade de números digitados: {contador}");

    if(contador == 0)
    {
        Console.WriteLine("Nenhum número foi digitado, portanto a média não pode ser calculada.");
    }
    else
    {
    float media = (float)soma / contador;
    Console.WriteLine($"A média dos números digitados é: {media}");
    }









