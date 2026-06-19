Console.WriteLine("Sistema de Boletim!\n");

string novoCadastro = "S";
double media;

while(novoCadastro.ToUpper() == "S")
{
    Console.Write("Digite o nome do aluno: ");
    string nomeAluno = Console.ReadLine();

    Console.Write("Digite a primeira nota do aluno: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.Write("Digite a segunda nota do aluno: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.Write("Digite a terceira nota do aluno: ");
    double nota3 = double.Parse(Console.ReadLine());

    Console.Write("Digite a quarta nota do aluno: ");
    double nota4 = double.Parse(Console.ReadLine());

   media = mediaAluno(nota1, nota2, nota3, nota4);
   Console.WriteLine(media);


    if (media >= 7){
        Console.WriteLine("Aprovado!");
    }
    else if(media >= 5 && media < 7)
    {
        Console.WriteLine("Recuperação");
    }
    else if(media < 5)
    {
        Console.WriteLine("Reprovado");
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }

    Console.WriteLine("\nDeseja cadastrar outro aluno? S/N");
    novoCadastro = Console.ReadLine();

    if(novoCadastro.ToUpper() == "N")
    {
        Console.WriteLine("Obrigado por utilizar nosso sistema!");
    }
}



double mediaAluno(double nota1, double nota2, double nota3, double nota4)
{
   return (nota1 + nota2 + nota3 + nota4) / 4;
}