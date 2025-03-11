namespace VISITOR.MODO_PADRAO;

public class Produto : IElemento
{
    private string _nome;
    private decimal _preco;
    private decimal _margemLucro;

    public Produto(string nome, decimal preco, decimal margemLucro)
    {
        _nome = nome;
        _preco = preco;
        _margemLucro = margemLucro;
    }

    public string GetNome() => _nome;
    public decimal GetPreco() => _preco;
    public decimal GetMargemLucro() => _margemLucro;

    public decimal Aceitar(IVisitor visitor) => visitor.VisitorProduto(this);
}