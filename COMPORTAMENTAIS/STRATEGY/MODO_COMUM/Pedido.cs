namespace STRATEGY.MODO_COMUM;

public class Pedido
{
    private decimal _valor;

    public decimal GetValor() => _valor;
    public void SetValor(decimal valor) => _valor = valor;
    public decimal CalcularFreteComum() => _valor * Convert.ToDecimal(0.05);
    public decimal CalcularFreteExpresso() => _valor * Convert.ToDecimal(0.10);
}