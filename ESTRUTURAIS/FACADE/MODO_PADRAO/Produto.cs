namespace FACADE.MODO_PADRAO;

public class Produto
{
    private readonly string _nome;
    private readonly string _descricao;
    private readonly decimal _valor;

    public Produto(string nome, string descricao, decimal valor)
    {
        _nome = nome;
        _descricao = descricao;
        _valor = valor;
    }

    public string GetNome() => _nome;
    public string GetDescricao() => _descricao;
    public decimal GetValor() => _valor;
}