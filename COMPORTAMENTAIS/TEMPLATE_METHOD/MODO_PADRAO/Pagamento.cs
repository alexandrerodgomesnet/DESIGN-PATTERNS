namespace TEMPLATE_METHOD.MODO_PADRAO;

public abstract class Pagamento
{
    protected decimal _valor;
    protected Gateway _gateway;

    public Pagamento(decimal valor, Gateway gateway)
    {
        _valor = valor;
        _gateway = gateway;
    }

    public abstract decimal CalcularTaxa();
    public abstract decimal CalcularDesconto();

    public bool RealizarCobranca()
    {
        var valorFinal = _valor + CalcularTaxa() - CalcularDesconto();

        var valorImpressao = $"{_valor} + {CalcularTaxa()} - {CalcularDesconto()} = ";
        Console.WriteLine(valorImpressao);

        return _gateway.Cobrar(valorFinal);
    }
}
