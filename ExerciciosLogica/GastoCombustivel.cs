int TempoViagem = int.Parse(Console.ReadLine());
int VelMedia = int.Parse(Console.ReadLine());

double CombustivelGasto = (TempoViagem * VelMedia) / 12.0;

Console.WriteLine($"{CombustivelGasto:F3}");