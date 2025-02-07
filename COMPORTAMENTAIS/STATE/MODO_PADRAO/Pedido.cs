namespace STATE.MODO_PADRAO;

public class Pedido
{
    private IState _aguardandoPagamento;
    private IState _pago;
    private IState _cancelado;
    private IState _enviado;

    private IState _estdoAtual;

    public Pedido()
    {
        _aguardandoPagamento = new AguardandoPagamento(this);
        _pago = new Pago(this);
        _cancelado = new Cancelado(this);
        _enviado = new Enviado(this);
        _estdoAtual = _aguardandoPagamento;
    }

    public void RealizarPagamento()
    {
        try
        {
            _estdoAtual.SucessoAoPagar();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void CancelarPedido()
    {
        try
        {
            _estdoAtual.CancelarPedido();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void DespacharPedido()
    {
        try
        {
            _estdoAtual.DespacharPedido();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void SetEstadoAtual(IState estadoAtual) => _estdoAtual = estadoAtual;
    public IState GetStateAguardandoPagamento() => _aguardandoPagamento;
    public IState GetStatePago() => _pago;
    public IState GetStateCancelado() => _cancelado;
    public IState GetStateEnviado() => _enviado;
}