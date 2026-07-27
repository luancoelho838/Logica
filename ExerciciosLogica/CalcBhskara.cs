string Valor = Console.ReadLine();
string [] Valores = Valor.Split(' ');

double A = double.Parse(Valores[0]);
double B = double.Parse(Valores[1]);
double C = double.Parse(Valores[2]);

double Delta = Math.Pow(B, 2) - (4 * A * C);

double R1 = (-B + Math.Sqrt(Delta)) / (2 * A);
double R2 = (-B - Math.Sqrt(Delta)) / (2 * A);

if(Delta < 0 || A == 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    Console.WriteLine($"R1 = {R1:F5}");
    Console.WriteLine($"R2 = {R2:F5}");
}