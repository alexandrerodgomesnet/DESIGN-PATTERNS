namespace STATE.MODO_PADRAO;

public interface IState
{
    void SucessoAoPagar();
    void CancelarPedido();
    void DespacharPedido();
}