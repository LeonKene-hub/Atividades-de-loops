//entrada
Console.WriteLine($"Por favor, informe uma nota de 0 a 10:");
int nota = int.Parse(Console.ReadLine());

//processo
while (nota < 0 || nota > 10)
{
    Console.WriteLine($"Por favor, informe um valor valido. Entre 0 e 10:");
    nota = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Obrigado!");