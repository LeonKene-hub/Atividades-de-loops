//entrada

//sexo da pessoa
char sexo = 'a';

int mulheres = 0;
int homens = 0;

//resposta da pessoa
char resposta = 'a';

int homensSim = 0;
int homensNao = 0;

int mulheresSim = 0;
int mulheresNao = 0;

for (int vezes = 1; vezes <= 10; vezes++)
{
    //sexo
    bool sexoCorreto = false;

    while (sexoCorreto == false)
    {
        //sexo
        Console.WriteLine($"{vezes}, Qual seu genero sexual? M para masculino, F para feminino:");
        sexo = char.Parse(Console.ReadLine().ToLower());

        if (sexo == 'f')
        {
            mulheres++;
            sexoCorreto = true;
        }
        else if (sexo == 'm')
        {
            homens++;
            sexoCorreto = true;
        }
        else
        {
            Console.WriteLine($"Sexo invalido, repita o processo a resposta");
            sexoCorreto = false;
        }
    }

    //resposta
    Console.WriteLine($"Voce aprova nosso novo produto? S para sim, N para nao:");
    resposta = char.Parse(Console.ReadLine().ToLower());

    if (sexo == 'm')
    {
        switch (resposta)
        {
            case 's':
                homensSim++;
                break;

            case 'n':
                homensNao++;
                break;

            default:
                Console.WriteLine($"Sua resposta esta errada e sera considerada como nao");
                homensNao++;
                break;
        }
    }
    else if (sexo == 'f')
    {
        switch (resposta)
        {
            case 's':
                mulheresSim++;
                break;

            case 'n':
                mulheresNao++;
                break;

            default:
                Console.WriteLine($"Sua resposta esta errada e sera considerada como nao");
                mulheresNao++;
                break;
        }
    }
}
//processo
int totalSim = mulheresSim + homensSim;
int totalNao = mulheresNao + homensNao;

float porcentagemHn = (homensNao * 100)/homens;
//saida

Console.WriteLine(@$"
/---------------------------------------------------------------
| homens: {homens}                                              
| respostas sim: {homensSim}                                    
| respostas nao: {homensNao}                                    
| porcentagem de homens que responderem nao: {porcentagemHn}%   
|---------------------------------------------------------------
| mulheres: {mulheres}                                          
| respostas sim: {mulheresSim}                                  
| respostas nao: {mulheresNao}                                  
|---------------------------------------------------------------
| total de respostas sim: {totalSim}                            
| total de respostas nao: {totalNao}                            
\---------------------------------------------------------------
");