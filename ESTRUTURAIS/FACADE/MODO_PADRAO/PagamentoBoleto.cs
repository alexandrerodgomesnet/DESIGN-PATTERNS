namespace FACADE.MODO_PADRAO;

public class PagamentoBoleto: Pagamento
{
    public PagamentoBoleto(Pedido pedido) : base(pedido) { }

    public override bool RealizarPagamento() => _pedido.GetValor() > 0;
}