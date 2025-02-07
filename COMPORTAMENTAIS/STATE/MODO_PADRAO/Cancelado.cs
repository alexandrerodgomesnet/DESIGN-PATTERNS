namespace STATE.MODO_PADRAO;

public class Cancelado: IState
{
    private Pedido _pedido;
    public Cancelado(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void CancelarPedido() => throw new Exception("Operação não suportada. O pedido já se encontra cancelado.");

    public void DespacharPedido() => throw new Exception("Operação não suportada. O pedido se encontra cancelado.");

    public void SucessoAoPagar() => throw new Exception("Operação não suportada. O pedido se encontra cancelado.");
}