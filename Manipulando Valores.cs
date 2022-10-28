using System.Globalization;

//Concatenação, Interpolação de Strings e Tratamento de Numeração

    string[] alunos = {"Ícaro","Samuel","João","Ribeiro"};
    for (int count = 0; count < alunos.Length; count++)
    {
        int exibicao = count + 1; //nao precisa, mas fica mais didático do que count+1 na string
        string texto = $"No {exibicao} - {alunos[count]}";
        Console.WriteLine(texto);
    }

//Concatenação de valores

    string numero1 = "10";
    string numero2 = "20";
    string resultado = numero1 + numero2;

    Console.WriteLine(resultado); // Imprime: 1020
    //Acontece pois estamos tratando de strings, se tratarmos de inteiros:

    int num1 = 10;
    int num2 = 20;

    int res = num1 + num2;

    Console.WriteLine(res); //Imprime: 30
    //Acontece pois estamos tratando de Inteiros

    string n1 = "10";
    int n2 = 20;

    string resposta = n1 + n2;
    Console.WriteLine(resposta); //Adiciona um numero ao final de um texto, então imprime: 1020

//Formatando Valores Monetarios e Alternando Localização do Código

    decimal valorMonetario = 82.40M;

    Console.WriteLine(valorMonetario); //imprime 82,40
    Console.WriteLine($"{valorMonetario:C}"); //imprime formatado em REAIS

    //Como alterar a localização do código?
    //A localização do código define o FORMATO da formatação :C, ou seja
    //Para aparecer em dolar, teriamos que mudar a localização para os EUA!!

    // 1 - Importamos a System.Glozalization (linha 1)
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

    Console.WriteLine($"{valorMonetario:C}"); //imprime formatado em DOLARES

    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

    //Alternando localização da cultura

    Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


//Representando porcentagem

    double porcentagem = .3421;

    Console.WriteLine(porcentagem.ToString("P")); // P de PORCENTAGEM

    int number = 123456;
    Console.WriteLine(number.ToString("##-##-##"));

//Formatando o tipo DateTime

    DateTime data = DateTime.Now; // Data atual do computador
    Console.WriteLine(data); // 28/10/2022 19:08:27
    Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Exibe tudo menos os segundos

//Formatando Data e Hora

    Console.WriteLine(data.ToShortTimeString()); //Exibe somente a hora

//DateTime com TryParse

    string dataString = "2022-04-17 18:00";

    DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
    Console.WriteLine(date);

//Validando o Retorno do TryParse

    bool sucesso = DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dato);
    if (sucesso)
    {
        Console.WriteLine($"Conversão com sucesso! {dato}");
    }
    else
    {
        Console.WriteLine($"{dataString} não é uma data válida!");
    }
