    int Tempo = int.Parse(Console.ReadLine());
    
    double Horas = Tempo / 3600;
    Tempo = Tempo % 3600;
    
    double Minutos = Tempo / 60;
    Tempo = Tempo % 60;
    
    double Segundos = Tempo / 1;
    
    
    
    Console.WriteLine($"{Horas}:{Minutos}:{Segundos}");