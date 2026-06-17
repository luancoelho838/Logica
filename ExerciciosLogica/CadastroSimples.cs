Console.WriteLine("Bem-vindo ao cadastro simples!\n");

Console.WriteLine("\nInforme o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("\nInforme a sua idade:");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("\nInforme a sua cidade:");
string cidade = Console.ReadLine();

Console.WriteLine("\nCadastro realizado com sucesso!");
Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nCidade: {cidade}");