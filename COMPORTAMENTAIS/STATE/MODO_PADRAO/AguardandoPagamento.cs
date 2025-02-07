namespace STATE.MODO_PADRAO;

public class AguardandoPagamento : IState
{
    private Pedido _pedido;
    public AguardandoPagamento(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void CancelarPedido() => _pedido.SetEstadoAtual(_pedido.GetStateCancelado());

    public void DespacharPedido() => throw new Exception("Operação não suportada. O pedido ainda não foi pago.");

    public void SucessoAoPagar() => _pedido.SetEstadoAtual(_pedido.GetStatePago());
}