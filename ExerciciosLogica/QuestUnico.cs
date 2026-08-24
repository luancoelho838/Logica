string resposta = "S";

while(resposta == "S")
{
    Console.WriteLine("Qual a instrução para sair de um loop?");
    Console.WriteLine("a. quit");
    Console.WriteLine("b. continue");
    Console.WriteLine("c. break");  
    Console.WriteLine("d. exit");

    Console.WriteLine("\nDigite a letra da alternativa correta: (Tecle x para sair)\n"); 
    string respostaUsuario = Console.ReadLine().ToLower();

    if(respostaUsuario == "c")
    {
        Console.WriteLine("\nParabéns! Você acertou a resposta!\n");
    }
    else if(respostaUsuario == "x")
    {
        Console.WriteLine("\nSaindo do loop...\n");
        resposta = "N";
    }
    else
    {
        Console.WriteLine("\nResposta incorreta. Tente novamente.\n");
    }


}