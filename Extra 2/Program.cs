//---------------------------------------------sexo----------------------------------------------//
int homens = 0;
int mulheres = 0;
string sexo = "a";

float pesoHomens = 0;
float pesoMulheres = 0;
float resposta = 0;

int idade = 0;
int idadeHomens = 0;
int idadeMulheres = 0;

for (int vezes = 1; vezes <= 10; vezes++)
{
    bool sexoCorreto = false;

    while (sexoCorreto == false)
    {
    Console.WriteLine($"{vezes}) Informe seu genero sexual, M para masculino e F para feminino:");
    sexo = Console.ReadLine().ToLower();

    if (sexo == "m")
    {
        homens++;
        sexoCorreto = true;
    }
    else if(sexo == "f")
    {
        mulheres++;
        sexoCorreto = true;
    }
    else
    {
        Console.WriteLine($"Infelizmente o dado infomado não se encaixa no que pedido, por vafor repita:");
        sexoCorreto = false;
    }
    }

    //---------------------------------------------peso----------------------------------------------//

    Console.WriteLine($"Informe o seu peso atual:");
    resposta = float.Parse(Console.ReadLine());

    if (sexo == "f")
    {
        pesoMulheres = pesoMulheres + resposta;
    }
    else if(sexo == "m")
    {
        pesoHomens = pesoHomens + resposta;
    }
    //---------------------------------------------idade----------------------------------------------//
    Console.WriteLine($"Informe a sua idade:");
    idade = int.Parse(Console.ReadLine());
    
    if (sexo == "f")
    {
        idadeMulheres = idadeMulheres + idade;
    }
    else if (sexo == "m")
    {
        idadeHomens = idadeHomens + idade;
    }
}

//processo
int mediaIdadeHomens = idadeHomens/homens;
int mediaIdadeMulheres = idadeMulheres/mulheres;
//saida
Console.WriteLine($"Homens: {homens} Mulheres: {mulheres}");
Console.WriteLine($"Média de idade dos homens: {mediaIdadeHomens}");
Console.WriteLine($"Média de idade dos mulheres: {mediaIdadeMulheres}");