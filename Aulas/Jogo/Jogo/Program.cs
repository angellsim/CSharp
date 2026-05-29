namespace Joguinho;

class Program
{
    enum NivelDeDificuldade
    {
        Facil = 0,
        Médio = 1, 
        Difícil = 2
    }

    static void Main(string[] args)
    {
        NivelDeDificuldade nivel = NivelDeDificuldade.Facil;

        int nivelInteiro = (int)nivel;

        Console.WriteLine(nivel.GetType());
        Console.WriteLine(nivelInteiro);
    }
}