//entrada
Console.WriteLine($"Informe o numero que deseja usar para formar a tabuada:");
int numero = int.Parse(Console.ReadLine());

int resultado = 0;
//processo
for (int vezes = 1; vezes <= 10; vezes++)
{
    resultado = numero * vezes;
    Console.WriteLine($"{numero} * {vezes} = {resultado}");
}

//saida
