Console.WriteLine("Verificação de ano bissexto!\n");

Console.WriteLine("Digite que ano deseja consultar: ");
double ano = double.Parse(Console.ReadLine());


if(ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
{
    Console.WriteLine($"O ano {ano} é bissexto!");
}
else
{
    Console.WriteLine($"O ano {ano} não é bissexto!");
}


