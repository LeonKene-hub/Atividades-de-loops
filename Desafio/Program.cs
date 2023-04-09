//numeros originais

int n1 = 0;
int n2 = 1;
int res = 0;

bool concluido = false;

while (concluido == false)
{
    Console.WriteLine(res);
    
    n1 = n2;
    n2 = res;
    res = n1 + n2;

    if (res > 500)
    {
        Console.WriteLine($"{res} Passou de 500!");
        concluido = true;
    }
    else
    {
        concluido = false;
    }
}