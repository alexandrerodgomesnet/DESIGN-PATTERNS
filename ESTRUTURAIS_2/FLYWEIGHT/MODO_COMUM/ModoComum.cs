using System.Text.Json.Serialization;

namespace FLYWEIGHT.MODO_COMUM;

public class ModoComum
{
    public static void Run()
    {
        var plantacao = new Plantacao();
        var interacaoes = 10;
        for (int i = 0; i < interacaoes; i++)
        {
            plantacao.AdicionarArvore(200, 300, "Ipê", "Marron", i+10);
            plantacao.AdicionarArvore(300, 200, "Coqueiro", "Vermelho", i+10);
            plantacao.AdicionarArvore(400, 100, "Jabuticabeira", "Vinho", i+10);
        }

        Console.WriteLine("### ARVORES ###");
        foreach (var item in plantacao.RetornarAvores())
        {
            Console.WriteLine(item);
        }
        
    }
}