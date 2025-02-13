namespace FACADE.MODO_COMUM;

public class PagamentoBoleto: Pagamento
{
    public PagamentoBoleto(Pedido pedido) : base(pedido) { }

    public override bool RealizarPagamento() => _pedido.GetValor() > 0;
}