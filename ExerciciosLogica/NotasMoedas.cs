    int Valor = (int)Math.Round(double.Parse(Console.ReadLine()) * 100);

    int C100 = Valor / 10000;
    Valor = Valor % 10000;

    int C50 = Valor / 5000;
    Valor = Valor % 5000;

    int C20 = Valor / 2000;
    Valor = Valor % 2000;

    int C10 = Valor / 1000;
    Valor = Valor % 1000;

    int C5 = Valor / 500;
    Valor = Valor % 500;

    int C2 = Valor / 200;
    Valor = Valor % 200;

    int M1 = Valor / 100;
    Valor = Valor % 100;

    int M050 = Valor / 50;
    Valor = Valor % 50;

    int M025 = Valor / 25;
    Valor = Valor % 25;

    int M010 = Valor / 10;
    Valor = Valor % 10;

    int M005 = Valor / 5;
    Valor = Valor % 5;

    int M001 = Valor / 1;

    Console.WriteLine("NOTAS:");
    Console.WriteLine($"{C100} nota(s) de R$ 100.00");
    Console.WriteLine($"{C50} nota(s) de R$ 50.00");
    Console.WriteLine($"{C20} nota(s) de R$ 20.00");
    Console.WriteLine($"{C10} nota(s) de R$ 10.00");
    Console.WriteLine($"{C5} nota(s) de R$ 5.00");
    Console.WriteLine($"{C2} nota(s) de R$ 2.00");
    Console.WriteLine("MOEDAS:");
    Console.WriteLine($"{M1} moeda(s) de R$ 1.00");
    Console.WriteLine($"{M050} moeda(s) de R$ 0.50");
    Console.WriteLine($"{M025} moeda(s) de R$ 0.25");
    Console.WriteLine($"{M010} moeda(s) de R$ 0.10");
    Console.WriteLine($"{M005} moeda(s) de R$ 0.05");
    Console.WriteLine($"{M001} moeda(s) de R$ 0.01");