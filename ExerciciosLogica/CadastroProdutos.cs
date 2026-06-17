Console.WriteLine("Cadastro simples de produtos!");

Console.WriteLine("Informe o nome do produto:");
string nomeProduto = Console.ReadLine();

Console.WriteLine("Informe o preço do produto:");
double precoProduto = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade:");
int quantidadeProduto = int.Parse(Console.ReadLine());

double valorTotal = (double)(precoProduto * quantidadeProduto);

Console.WriteLine("\nResumo do cadastro:");
Console.WriteLine($"Produto: {nomeProduto}\nPreço: R${precoProduto:F2}\nQuantidade: {quantidadeProduto}\nValor Total: R${valorTotal:F2}");