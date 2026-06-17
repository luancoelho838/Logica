Console.WriteLine("Calculadora de Média!\n");

Console.WriteLine("Informe a primeira nota:");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"A média das notas é: {media:F2}");