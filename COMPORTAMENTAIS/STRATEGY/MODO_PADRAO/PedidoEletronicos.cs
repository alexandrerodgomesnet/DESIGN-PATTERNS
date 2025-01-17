namespace STRATEGY.MODO_PADRAO;

public class PedidoEletronicos : Pedido
{
    private string _nomeSetor;
    public PedidoEletronicos()
    {
        _nomeSetor = "Móveis";
    }

    // public override decimal CalcularFreteComum() => GetValor() * Convert.ToDecimal(0.05);

    // public override decimal CalcularFreteExpresso()=> GetValor() * Convert.ToDecimal(0.1);

    public string GetNomeSetor() => _nomeSetor;
    public void SetNomeSetor(string nome) => _nomeSetor = nome;
}
