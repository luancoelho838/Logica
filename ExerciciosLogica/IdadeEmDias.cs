    int IdadeDias = int.Parse(Console.ReadLine());
    
    double Ano = IdadeDias / 365;
    IdadeDias = IdadeDias % 365;
    
    double Meses = IdadeDias / 30;
    IdadeDias = IdadeDias % 30;
    
    double Dias = IdadeDias / 1;
    
    Console.WriteLine($"{Ano} ano(s)\n{Meses} mes(es)\n{Dias} dia(s)");