namespace PROTOTYPE.MODO_PADRAO;

public class GerenciadorPrototipos
{
    private Dictionary<string, IPrototype> _prototipos = new();

    public GerenciadorPrototipos()
    {
        var livro = new Livro();        
        livro.SetNome("Desconhecido");
        livro.SetAutor("Desconhecido");
        livro.SetNumeroPaginas(0);

        _prototipos.Add("livro", livro);

        var revista = new Revista();        
        revista.SetNome("Desconhecido");
        revista.SetEdicao(0);

        _prototipos.Add("revista", revista);

        var trabalho = new Trabalho();        
        trabalho.SetNome("Desconhecido");
        trabalho.SetAutor("Desconhecido");
        trabalho.SetTipo("Desconhecido");

        _prototipos.Add("trabalho", trabalho);
    }

    public IPrototype GetInstance(string identificador) => _prototipos[identificador];
}