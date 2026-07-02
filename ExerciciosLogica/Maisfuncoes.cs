Saudar();



Console.WriteLine("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

double resultado = Media(nota1, nota2, nota3);
Console.WriteLine($"\nA média das notas é: {resultado}\n");




Console.WriteLine("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());    
    
VerificarNumPar(num);



/*Funções*/

void Saudar()
{
    Console.WriteLine("Olá! Seja bem-vindo(a) ao programa!\n");
}


double Media(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;
}


void VerificarNumPar(int num)
{
    if (num % 2 == 0)
    {
        Console.WriteLine($"\nO número {num} é par.");
    }
    else
    {
        Console.WriteLine($"\nO número {num} é ímpar.");
    }
}
