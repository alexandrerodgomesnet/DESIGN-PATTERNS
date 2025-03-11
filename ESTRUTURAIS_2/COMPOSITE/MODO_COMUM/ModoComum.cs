namespace COMPOSITE.MODO_COMUM;

public class ModoComum
{
    public static void Run()
    {
        var raiz = new Pasta("Raiz", "/");
        var arquivo1 = new Arquivo("Arquivo 1", "/arquivo1");
        var arquivo2 = new Arquivo("Arquivo 2", "/arquivo2");
        var arquivo3 = new Arquivo("Arquivo 3", "/arquivo3");
        var arquivo4 = new Arquivo("Arquivo 4", "/arquivo4");
        var arquivo5 = new Arquivo("Arquivo 5", "/arquivo5");
        var arquivo6 = new Arquivo("Arquivo 6", "/arquivo6");

        raiz.Adicionar(arquivo1);
        raiz.Adicionar(arquivo2);
        raiz.Adicionar(arquivo3);
        raiz.Adicionar(arquivo4);
        raiz.Adicionar(arquivo5);
        raiz.Adicionar(arquivo6);

        raiz.Exibir();
    }
}
