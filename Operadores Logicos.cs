//or, and, not//

//or = ||

bool ehMaiorDeIdade = true;
bool possuiAutorizacao = false;

if (ehMaiorDeIdade || possuiAutorizacao)
{
  Console.WriteLine("Entrada Liberada");
}
else
{
  Console.WriteLine("Entrada nao liberada");
}

//and = &&

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
  Console.WriteLine("Aprovado!");
}
else
{
  Console.WriteLine("Reprovado!");
}

//not = !

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
  Console.WriteLine("Vou pedalar!");
}
else
{
  Console.WriteLine("Vou ficar em casa");
}
