namespace VISITOR.MODO_PADRAO;

public class Departamento : IElemento
{
    private string _nome;
    private List<Produto> _produtos;

    public Departamento(string nome)
    {
        _nome = nome;
        _produtos = [];
    }

    public void AdicionarProduto(Produto produto) => _produtos.Add(produto);
    public string GetNome() => _nome;
    public List<Produto> GetProdutos() => _produtos;

    public decimal Aceitar(IVisitor visitor) => visitor.VisitorDepartamento(this);
}