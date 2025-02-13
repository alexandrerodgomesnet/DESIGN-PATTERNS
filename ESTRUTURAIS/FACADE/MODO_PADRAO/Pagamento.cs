namespace FACADE.MODO_PADRAO;

public abstract class Pagamento
{
    protected Pedido _pedido;
    public Pagamento(Pedido pedido)
    {
        _pedido = pedido;
    }

    public abstract bool RealizarPagamento();
}