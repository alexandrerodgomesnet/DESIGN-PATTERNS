namespace TEMPLATE_METHOD.MODO_PADRAO;

public class PagamentoCredito(decimal valor, Gateway gateway) : Pagamento(valor, gateway)
{
    public override decimal CalcularTaxa() => _valor * Convert.ToDecimal(0.05);

    public override decimal CalcularDesconto()
    {
        if(_valor > 300)
            return _valor * Convert.ToDecimal(0.02);

        return 0;
    }
}
