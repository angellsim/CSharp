using Ex001.Adjacentes;

namespace Ex001;

public class Program
{
    static void Main(string[] args)
    {
        Personagem meuPersonagem = new Personagem();
        UsarItem usarItem = new UsarItem();

        meuPersonagem.Atacar();
        usarItem.PocaoHP();

    }
}