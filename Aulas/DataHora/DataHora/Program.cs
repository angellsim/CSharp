using System.Globalization;

namespace DateHour;

public class Program
{
    static void Main(string[] args)
    {
        DateOnly data = new DateOnly(2027, 12, 19);

        string diaEmTexto = data.ToString("D", new CultureInfo("pt-BR"));

        DateTime data1 = new DateTime(2027, 12, 19, 20, 15, 40);

        string dia1EmTexto = data1.ToString("D", new CultureInfo("pt-BR"));

        DateTime hoje = DateTime.UtcNow;

        DateTime hojeMaisUm = hoje.AddDays(1);

        Console.WriteLine(hoje);
        Console.WriteLine(hojeMaisUm);

        /*Console.WriteLine(data1);*/
    }
}


