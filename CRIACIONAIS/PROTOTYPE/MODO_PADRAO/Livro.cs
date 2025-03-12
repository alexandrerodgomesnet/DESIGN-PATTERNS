namespace PROTOTYPE.MODO_PADRAO;

public class Livro : IPrototype
{
    private string _nome = string.Empty;
    private string _autor = string.Empty;
    private int _numeroPaginas;

    public string GetNome() => _nome;
    public void SetNome(string nome) => _nome = nome;
    public string GetAutor() => _autor;
    public void SetAutor(string autor) => _autor = autor;
    public int GetNumeroPaginas() => _numeroPaginas;
    public void SetNumeroPaginas(int numeroPaginas) => _numeroPaginas = numeroPaginas;
    public override string ToString() =>
        $"Nome: {_nome}; Autor: {_autor}; Número de Paginas: {_numeroPaginas}";

    public IPrototype Clone()
    {
        var livro = new Livro();        
        livro.SetNome(_nome);
        livro.SetAutor(_autor);
        livro.SetNumeroPaginas(_numeroPaginas);
        return livro;
    }
}