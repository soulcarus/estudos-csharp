int quantidade_em_estoque = 10;
int quantidade_compra = 4;

if (quantidade_em_estoque >= quantidade_compra)
{
  Console.WriteLine("Venda Realizada");
}
else
{
  Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
}

//ou

int quantidade_em_estoque = 10;
int quantidade_compra = 4;
bool possivel_venda = quantidade_em_estoque >= quantidade_compra;

Console.WriteLine($"Quantidade em estoque: {quantidade_em_estoque}");
Console.WriteLine($"Quantidade compra: {quantidade_compra}");
Console.WriteLine($"É possível realizar a venda?: {possivel_venda}");

if (possivel_venda)
{
  Console.WriteLine("Venda Realizada");
}
else
{
  Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
}

//IF ANINHADO

int quantidade_em_estoque = 10;
int quantidade_compra = 4;
bool possivel_venda = quantidade_em_estoque >= quantidade_compra;

Console.WriteLine($"Quantidade em estoque: {quantidade_em_estoque}");
Console.WriteLine($"Quantidade compra: {quantidade_compra}");
Console.WriteLine($"É possível realizar a venda?: {possivel_venda}");

if(quantidade_compra == 0)
{
  Console.WriteLine("Venda Inválida");
}
else if (possivel_venda)
{
  Console.WriteLine("Venda Realizada");
}
else
{
  Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
}

//SWITCH CASE

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a")
{
  Console.WriteLine("Vogal");
}
else if (letra == "e")
{
  Console.WriteLine("Vogal");
}
else if (letra == "o")
{
  Console.WriteLine("Vogal");
}
else if (letra == "u")
{
  Console.WriteLine("Vogal");
}
else
{
  Console.WriteLine("Não é vogal");
}

//PARE DE FAZER ASSIM!

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
 Console.WriteLine("Vogal");
}
else
{
Console.WriteLine("Nao eh Vogal");
}

//mas, e se fosse assim?

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
case "a";
case "e";
case "i";
case "o";
case "u";
  Console.WriteLine("Vogal!");
  break;
  
default:
  Console.WriteLine("Nao eh uma vogal");
  break;
}
