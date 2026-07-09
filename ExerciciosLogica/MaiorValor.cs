string valor = Console.ReadLine();
string[] valores = valor.Split(' ');
int A = int.Parse(valores[0]);
int B = int.Parse(valores[1]);
int C = int.Parse(valores[2]);

int MaiorValor = ( A + B + Math.Abs(A - B) ) / 2;
int MaiorValor2 = ( MaiorValor + C + Math.Abs(MaiorValor - C) ) / 2;

Console.WriteLine($"{MaiorValor2} eh o maior");