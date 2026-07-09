int X = int.Parse(Console.ReadLine());
double Y = double.Parse(Console.ReadLine());

double consumo = (double) X / Y;

Console.WriteLine($"{consumo:F3} km/l");