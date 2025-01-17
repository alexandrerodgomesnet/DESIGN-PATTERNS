namespace TEMPLATE_METHOD.MODO_COMUM;

public class PagamentoCredito
{
    private decimal _valor;
    private Gateway _gateway;

    public PagamentoCredito(decimal valor, Gateway gateway)
    {
        _valor = valor;
        _gateway = gateway;
    }

    public decimal CalcularTaxa() => _valor * Convert.ToDecimal(0.05);

    public decimal CalcularDesconto()
    {
        if(_valor > 300)
            return _valor * Convert.ToDecimal(0.02);

        return 0;
    }

    public bool RealizarCobranca()
    {
        var valorFinal = _valor + CalcularTaxa() - CalcularDesconto();
        return _gateway.Cobrar(valorFinal);
    }
}
