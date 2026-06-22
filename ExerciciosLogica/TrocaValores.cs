Console.WriteLine("Troca de valoresw!\n");

Console.WriteLine("Digite o primeiro valor: ");
double var1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
double var2 = double.Parse(Console.ReadLine());

(var1, var2) = (var2,var1);

Console.WriteLine($"O primeiro valor é {var1} e o segundo valor é {var2}");

