using System.Text;

namespace OperacoesTexto;

class Program()
{
    static void Main(string[] args)
    {
        /*string string1 = "Satoru Gojo";
        string string2 = @"é o mais forte\t do mundo!";*/

        /*string stringCompleta = string1 + " " + string2;

        Console.WriteLine(stringCompleta);*/

        //string paragrafo1 = $"primeiro paragrafo {7} tem {true} muitas coisas {string1} e {string2}";

        //Console.WriteLine(paragrafo1);

        /*StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(string1);
        stringBuilder.Append(string2);

        string resultado = stringBuilder.ToString();

        Console.WriteLine(resultado);*/

        string texto = "A {0} gosta da {1}";

        string resultado = string.Format(texto, "Satoru Gojo", "Alice");

        Console.WriteLine(resultado);
    }
}
