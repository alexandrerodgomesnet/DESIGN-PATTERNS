namespace CHAIN_OF_RESPONSIBILITY.MODO_COMUM;

public class Pedido
{
    private decimal _valor;

    public decimal GetValor() => _valor;
    public void SetValor(decimal valor) => _valor = valor;
}