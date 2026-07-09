    string valor = Console.ReadLine();
    string[] valores = valor.Split(' ');
    double x1 = double.Parse(valores[0]);
    double y1 = double.Parse(valores[1]);

    valor = Console.ReadLine();
    valores = valor.Split(' ');
    
    double x2 = double.Parse(valores[0]);
    double y2 = double.Parse(valores[1]);
    
    double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

    Console.WriteLine($"{distancia:F4}");