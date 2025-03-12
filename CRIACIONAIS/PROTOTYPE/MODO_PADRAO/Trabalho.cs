namespace PROTOTYPE.MODO_PADRAO;

public class Trabalho : IPrototype
 {
    private string _nome = string.Empty;
    private string _autor = string.Empty;
    private string _tipo = string.Empty;

    public string GetNome() => _nome;
    public void SetNome(string nome) => _nome = nome;
    public string GetAutor() => _autor;
    public void SetAutor(string autor) => _autor = autor;
    public string GetTipo() => _tipo;
    public void SetTipo(string tipo) => _tipo = tipo;
    public override string ToString() =>
        $"Nome: {_nome}; Autor: {_autor}; Tipo: {_tipo}";

    public IPrototype Clone()
    {
        var trabalho = new Trabalho();        
        trabalho.SetNome(_nome);
        trabalho.SetAutor(_autor);
        trabalho.SetTipo(_tipo);
        return trabalho;
    }
}
