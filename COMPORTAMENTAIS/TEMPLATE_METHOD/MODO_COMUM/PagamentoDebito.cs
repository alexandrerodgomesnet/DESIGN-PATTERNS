namespace TEMPLATE_METHOD.MODO_COMUM;

public class PagamentoDebito
{
    private decimal _valor;
    private Gateway _gateway;

    public PagamentoDebito(decimal valor, Gateway gateway)
    {
        _valor = valor;
        _gateway = gateway;
    }

    public decimal CalcularTaxa() => 4;

    public decimal CalcularDesconto()
    {
        return _valor * Convert.ToDecimal(0.05);
    }

    public bool RealizarCobranca()
    {
        var valorFinal = _valor + CalcularTaxa() - CalcularDesconto();
        return _gateway.Cobrar(valorFinal);
    }
}
