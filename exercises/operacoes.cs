namespace Operacoes;

public static class Exercicios
{
    private static void CalculeteAllOps(double a, double b)
    {
        Console.WriteLine($"Soma: {a + b}");
        Console.WriteLine($"Subtração: {a - b}");
        Console.WriteLine($"Multiplicação: {a * b}");
        Console.WriteLine($"Divisão: {a / b}");
        Console.WriteLine($"Resto: {a % b}");
        Console.WriteLine($"Potência: {Math.Pow(a, b)}");
        Console.WriteLine($"Raiz: {Math.Sqrt(a)}");
    }

    public static void ExecOps()
    {
        Console.Write("\nDigite o primeiro número: ");
        double a = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine()!);
        CalculeteAllOps(a, b);
    }
}
