namespace STATE.MODO_PADRAO;

public class Enviado: IState
{
    private Pedido _pedido;
    public Enviado(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void CancelarPedido() => throw new Exception("Operação não suportada. O pedido já enviado.");

    public void DespacharPedido() => throw new Exception("Operação não suportada. O pedido já enviado.");

    public void SucessoAoPagar() => throw new Exception("Operação não suportada. O pedido já foi pago e enviado.");
}