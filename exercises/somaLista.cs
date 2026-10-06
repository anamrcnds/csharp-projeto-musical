namespace Somar;


public static class UmaLista {
    private static readonly List<int> lista = new List<int>(){10, 2, 3};
    public static void ExecSomaLista()
    {
        Console.WriteLine("\nSoma da lista: " + lista.Sum());
    }
}