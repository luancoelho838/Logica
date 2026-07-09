
const double pi = 3.14159;


string lados = Console.ReadLine();
string[] valores = lados.Split(' ');
double A = double.Parse(valores[0]);
double B = double.Parse(valores[1]);
double C = double.Parse(valores[2]);


double areaTriangulo = (A * C) / 2;
double areaCirculo = pi * Math.Pow(C, 2);
double areaTrapezio = ((A + B) * C) / 2;
double areaQuadrado = Math.Pow(B, 2);
double areaRetangulo = A * B;

Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");