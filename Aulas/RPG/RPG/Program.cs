namespace Rpg.Classes;

public class Program
{

    enum Classes
    {
        Arqueira = 0,
        Bruxa = 1,
        Feiticeira = 2,
        Maga = 3,
        Guerreira = 4,
        Barbara = 5
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma classe para jogar: ");

        Console.WriteLine(Classes.Arqueira + " [0] " + Classes.Bruxa + " [1] " + Classes.Barbara + " [2] " + Classes.Guerreira
            + " [3] " + Classes.Maga + " [4] " + Classes.Feiticeira + " [5] ");

        int escolhaClasse = Convert.ToInt32(Console.ReadLine());

        
        
        switch (escolhaClasse)
        {
            case 0:
                Console.WriteLine("Arqueira");
                Console.WriteLine("Destreza");
                break;
            case 1:
                Console.WriteLine("Bruxa");
                Console.WriteLine("Magia");
                break;
            case 2:
                Console.WriteLine("Feiticeira");
                Console.WriteLine("Sabedoria");
                break;
            case 3:
                Console.WriteLine("Maga");
                Console.WriteLine("Inteligência");
                break;
            case 4:
                Console.WriteLine("Guerreira");
                Console.WriteLine("Força");
                break;
            case 5:
                Console.WriteLine("Barbara");
                Console.WriteLine("Constituição");
                break;
        }
    }
}