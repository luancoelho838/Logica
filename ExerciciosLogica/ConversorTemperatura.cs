Console.WriteLine("Conversor de graus Celsius para graus Fahrenheit!\n");

Console.WriteLine("Informe a temperatura em graus celsius: ");
double tempC = double.Parse(Console.ReadLine());

double tempF = (tempC * 9/5) + 32;

Console.WriteLine($"A temperatura em graus Celsius é {tempC} e em graus Fahrenheit é {tempF}");