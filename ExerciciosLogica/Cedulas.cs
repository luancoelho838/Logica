int Dinheiro = int.Parse(Console.ReadLine());
Console.WriteLine($"{Dinheiro}");

int C100 = Dinheiro / 100;
Console.WriteLine($"{C100} nota(s) de R$ 100,00");
Dinheiro = Dinheiro % 100;

int C50 = Dinheiro / 50;
Console.WriteLine($"{C50} nota(s) de R$ 50,00");
Dinheiro = Dinheiro % 50;

int C20 = Dinheiro / 20;
Console.WriteLine($"{C20} nota(s) de R$ 20,00");
Dinheiro = Dinheiro % 20;

int C10 = Dinheiro / 10;
Console.WriteLine($"{C10} nota(s) de R$ 10,00");
Dinheiro = Dinheiro % 10;

int C5 = Dinheiro / 5;
Console.WriteLine($"{C5} nota(s) de R$ 5,00");
Dinheiro = Dinheiro % 5;

int C2 = Dinheiro / 2;
Console.WriteLine($"{C2} nota(s) de R$ 2,00");
Dinheiro = Dinheiro % 2;

int C1 = Dinheiro / 1;
Console.WriteLine($"{C1} nota(s) de R$ 1,00");