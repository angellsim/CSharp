namespace TiposTexto;

class Program()
{
    static void Main(string[] args)
    {
        char letra = 'a';
        char num = '0';
        char caractere = '@';
        char espaco = ' ';

        string texto = "Luffy vai ser o Rei dos Piratas!";
        char primeiraLetra = texto[5];

        string nome1 = "                Monkey D. Satoru Luffy";

        string nome2 = "satoru";

        bool existe = nome1.Contains(nome2);

        Console.WriteLine(existe);

        // False

        /*string nomeAposReplace = nome2.Replace(' ', 'u');

        Console.WriteLine(nomeAposReplace);*/

        // SatoruuuuuuuuGojo

        /*bool comecaComS = nome2.StartsWith("Sator");

        Console.WriteLine(comecaComS);*/

        // True

        /*string nomeSemEspaco = nome.Trim();
        string nome2SemEspaco = nome2.Trim();

        Console.WriteLine(nome);
        Console.WriteLine(nomeSemEspaco);

        Console.WriteLine("==============");
        Console.WriteLine(nome2);
        Console.WriteLine(nome2SemEspaco);*/

    }
}