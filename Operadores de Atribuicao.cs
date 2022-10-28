//Conversão para String:

int inteiro = 5;
string a = inteiro.ToString();

//Cast simples

int x = 5;
double y = Convert.ToDouble(x);

//Parse

string um = "15-";
int b = 0;

int.TryParse(a, out b);

//Trocar de valores

int valor1 = 2;
int valor2 = 5;
int temporario = 0;

temporario = valor1;
valor1 = valor2;
valor2 = temporario;
