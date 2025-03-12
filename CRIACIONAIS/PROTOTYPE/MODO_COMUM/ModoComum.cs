namespace PROTOTYPE.MODO_COMUM;

public class ModoComum
{
    public static void Run()
    {
        Console.WriteLine("Livro 1");

        var livro1 = new Livro();        
        livro1.SetNome("Livro 1");
        livro1.SetAutor("Autor Livro 1");
        livro1.SetNumeroPaginas(112);

        Console.WriteLine("Livro 1 com valores editados.");
        Console.WriteLine(livro1);

        Console.WriteLine("Livro 2");

        var livro2 = new Livro();        
        livro2.SetNome("Livro 2");
        livro2.SetAutor("Autor Livro 2");
        livro2.SetNumeroPaginas(100);

        Console.WriteLine("Livro 2 com valores editados.");
        Console.WriteLine(livro2);
    }
}