Console.WriteLine("Sistema simples de login!");

string usuário_correto = "admin";
string senha_correta = "1234";

Console.WriteLine("Informe o nome de usuário:");
string usuario = Console.ReadLine();

Console.WriteLine("Informe a senha:");
string senha = Console.ReadLine();  

if (usuario == usuario_correto && senha == senha_correta)
{
    Console.WriteLine("Login bem-sucedido! Seja bem-vindo, admin!");
}
else
{
    Console.WriteLine("Login falhou! Nome de usuário ou senha incorretos.");
}