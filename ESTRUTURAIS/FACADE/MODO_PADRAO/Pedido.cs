namespace FACADE.MODO_PADRAO;

public class Pedido
{
    private Consumidor _consumidor;
    private List<Produto> _produtos= [];
    private decimal _valor = 0;

    public Pedido(Consumidor consumidor)
    {
        _consumidor = consumidor;
    }

    public void SetConsumidor(Consumidor consumidor) => _consumidor = consumidor;

    public void AddProduto(Produto produto)
    {
        _produtos.Add(produto);
        _valor += produto.GetValor();
    }

    public Consumidor GetConsumidor() => _consumidor;
    public List<Produto> GetProdutos() => _produtos;
    public decimal GetValor() => _valor;
}