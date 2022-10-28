//METODOS DE CRIAR ARRAYS

int[] array = new int[5];
int[] _4_numeros = {10,20,30,40};
string[] nomes = {"Jan","Fev"};

int elemento = array[0];
array[0] = 42;

//PERCORRENDO ARRAYS COM LOOPS OU FOREACH

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;


Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

int[] ArrayInteirosDobrado = new int[arrayInteiros.Length * 2];

Array.Copy(arrayInteiros, ArrayInteirosDobrado, arrayInteiros.Length);


Console.WriteLine("Percorrendo o array com o for\n");
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição numero {contador}, com numero {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o array com foreach\n");
int contadorForEach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição numero {contadorForEach}, com numero {valor}");
    contadorForEach++;
}

//CRIANDO STRING NOVA

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("SC");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("OIE");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("JI");

for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N {contador} - {listaString[contador]}");
}

int contadorForEach = 0;
foreach(string elementos in listaString)
{
    Console.WriteLine($"Posição N {contadorForEach} - {elementos}");
    contadorForEach++;
}
