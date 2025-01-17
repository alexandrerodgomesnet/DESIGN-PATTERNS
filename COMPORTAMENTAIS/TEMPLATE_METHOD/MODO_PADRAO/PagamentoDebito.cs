namespace TEMPLATE_METHOD.MODO_PADRAO;

public class PagamentoDebito(decimal valor, Gateway gateway) : Pagamento(valor, gateway)
{
    public override decimal CalcularTaxa() => 4;

    public override decimal CalcularDesconto()
    {
        return _valor * Convert.ToDecimal(0.05);
    }
}