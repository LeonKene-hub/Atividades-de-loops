//entrada de dados
Console.WriteLine($"Digite o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Digite o sua senha:");
string senha = Console.ReadLine();

//processo
while (nome == senha)
{
    Console.WriteLine($"[ERRO] Nome e senha nao podem ser iguais, por favor escolha outro nome e senha:");
    
    Console.WriteLine($"Digite o seu nome:");
    nome = Console.ReadLine();
    
    Console.WriteLine($"Digite o sua senha:");
    senha = Console.ReadLine();
}

//saida
Console.WriteLine($"Cadastro completo. Seja bem vindo!"); 