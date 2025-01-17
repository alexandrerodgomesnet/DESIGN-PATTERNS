namespace STRATEGY.MODO_PADRAO;

public class PedidoMoveis : Pedido
{
    private string _nomeSetor;
    public PedidoMoveis()
    {
        _nomeSetor = "Eletrônicos";
    }

    // public override decimal CalcularFreteComum() => GetValor() * Convert.ToDecimal(0.05);

    // public override decimal CalcularFreteExpresso()=> throw new Exception("Frete indisponível.");

    public string GetNomeSetor() => _nomeSetor;
    public void SetNomeSetor(string nome) => _nomeSetor = nome;
}
