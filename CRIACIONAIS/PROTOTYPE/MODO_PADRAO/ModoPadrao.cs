namespace PROTOTYPE.MODO_PADRAO;

public class ModoPadrao
{
    public static void Run()
    {
        var gerenciadorPrototipo = new GerenciadorPrototipos();
        Console.WriteLine("Livro 1");

        var livroPrototipo = gerenciadorPrototipo.GetInstance("livro");
        var livro1 = livroPrototipo.Clone() as Livro;

        Console.WriteLine("Livro 1 com valores Padrões.");
        Console.WriteLine(livro1);
        livro1.SetNome("Livro 1");
        livro1.SetAutor("Autor Livro 1");
        livro1.SetNumeroPaginas(112);

        Console.WriteLine("Livro 1 com valores editados.");
        Console.WriteLine(livro1);

        Console.WriteLine("Livro 2");

        var livro2 = livroPrototipo.Clone() as Livro; 
        livro2.SetNome("Livro 2");
        livro2.SetAutor("Autor Livro 2");
        livro2.SetNumeroPaginas(100);

        Console.WriteLine("Livro 2 com valores editados.");
        Console.WriteLine(livro2);
    }
}