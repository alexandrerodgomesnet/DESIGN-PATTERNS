namespace TEMPLATE_METHOD.MODO_COMUM;

public class PagamentoDinheiro
{
    private decimal _valor;
    private Gateway _gateway;

    public PagamentoDinheiro(decimal valor, Gateway gateway)
    {
        _valor = valor;
        _gateway = gateway;
    }

    public decimal CalcularTaxa() => 0;

    public decimal CalcularDesconto()
    {
        return _valor * Convert.ToDecimal(0.1);
    }

    public bool RealizarCobranca()
    {
        var valorFinal = _valor + CalcularTaxa() - CalcularDesconto();
        return _gateway.Cobrar(valorFinal);
    }
}
