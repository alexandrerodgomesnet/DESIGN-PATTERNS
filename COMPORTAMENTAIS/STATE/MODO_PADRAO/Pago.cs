namespace STATE.MODO_PADRAO;

public class Pago: IState
{
    private Pedido _pedido;
    public Pago(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void CancelarPedido() => _pedido.SetEstadoAtual(_pedido.GetStateCancelado());

    public void DespacharPedido() => _pedido.SetEstadoAtual(_pedido.GetStateEnviado());

    public void SucessoAoPagar() => throw new Exception("Operação não suportada. O pedido já foi pago.");
}