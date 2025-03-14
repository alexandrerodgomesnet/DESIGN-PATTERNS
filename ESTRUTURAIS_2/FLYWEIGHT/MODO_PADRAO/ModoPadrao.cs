using Newtonsoft.Json;

namespace FLYWEIGHT.MODO_PADRAO;

public class ModoPadrao
{
    public static void Run()
    {
        var plantacao = new Plantacao();
        var interacaoes = 10;
        for (int i = 0; i < interacaoes; i++)
        {
            plantacao.AdicionarArvore(200, 300, "Ipê", "Marron", 10);
            plantacao.AdicionarArvore(300, 200, "Coqueiro", "Vermelho", 7);
            plantacao.AdicionarArvore(400, 100, "Jabuticabeira", "Vinho", 5);
        }

        Console.WriteLine("### Espécies ###");

        foreach (var item in plantacao.RetornarEspecies())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("### ARVORES ###");
        foreach (var item in plantacao.RetornarAvores())
        {
            Console.WriteLine(item);
        }
        
    }
}