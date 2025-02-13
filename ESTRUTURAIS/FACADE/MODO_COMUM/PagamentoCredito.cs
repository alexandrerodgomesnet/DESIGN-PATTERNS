namespace FACADE.MODO_COMUM;

public class PagamentoCredito : Pagamento
{
    public PagamentoCredito(Pedido pedido) : base(pedido) { }

    public override bool RealizarPagamento() => _pedido.GetValor() > 0;
}