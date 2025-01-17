namespace TEMPLATE_METHOD.MODO_PADRAO;

public class PagamentoDinheiro(decimal valor, Gateway gateway) : Pagamento(valor, gateway)
{
    public override decimal CalcularTaxa() => 0;
    public override decimal CalcularDesconto()
    {
        return _valor * Convert.ToDecimal(0.1);
    }
}
