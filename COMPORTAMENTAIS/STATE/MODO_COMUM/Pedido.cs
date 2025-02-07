namespace STATE.MODO_COMUM;

public class Pedido
{
    public const int AGUARDANDO_PAGAMENTO = 1;
    public const int PAGO = 2;
    public const int CANCELADO = 3;
    public const int ENVIADO = 4;

    private int _estadoAtual = 0;

    public Pedido()
    {
        _estadoAtual = AGUARDANDO_PAGAMENTO;
    }

    public void SucessoAoPagar()
    {
        if(_estadoAtual == AGUARDANDO_PAGAMENTO)
            _estadoAtual = PAGO;
        else
            Console.WriteLine("O pedido não está aguardando pagamento.");
    }

    public void CancelarPedido()
    {
        if(_estadoAtual == AGUARDANDO_PAGAMENTO || _estadoAtual == PAGO)
            _estadoAtual = CANCELADO;
        else
            Console.WriteLine("O pedido não pode ser cancelado.");
    }

    public void DespacharPedido()
    {
        if(_estadoAtual == PAGO)
            _estadoAtual = ENVIADO;
        else
            Console.WriteLine("O pedido não pode ser enviado.");
    }
}
