public class Calculadora
{
    public void Somar(int x, int y)
    {
        Console.WriteLine($"A soma de {x} com {y} é: {x+y}");
    }
    public void Subtrair(int x, int y)
    {
        Console.WriteLine($"A subtração de {x} e {y} é: {x-y}");
    }
    public void Dividir(int x, int y)
    {
        Console.WriteLine($"A divisão de {x} e {y} é: {x/y}");
    }
    public void Multiplicar(int x, int y)
    {
        Console.WriteLine($"A divisão de {x} e {y} é: {x*y}");
    }
    public void Potencia(int x, int y)
    {
        double resultado = Math.Pow(x,y);
        Console.WriteLine($"{x}^{y} = {resultado}");
    }
    public void Seno(double angulo)
    {
        double radiano = angulo * Math.PI/180;
        double seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");

    }
    public void Coseno(double angulo)
    {
        double radiano = angulo * Math.PI/180;
        double cosseno = Math.Cos(radiano);
        Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno,4)}");

    }
    public void Tangente(double angulo)
    {
        double radiano = angulo * Math.PI/180;
        double tangente = Math.Tan(radiano);
        Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente,4)}");

    }
    public void RaizQuadrada(double x)
    {
        double raiz = Math.Sqrt(x);
        Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
    }
}
