
namespace FACTORY_METHOD.MODO_PADRAO_1;

public abstract class Boleto
{
    protected decimal _valor;
    protected decimal juros;
    protected decimal desconto;
    protected decimal multa;

    public Boleto(decimal valor)
    {
        _valor = valor;
    }

    public decimal CalcularDesconto() => _valor * desconto;

    public decimal CalcularJuros() => _valor * juros;

     public decimal CalcularMulta() => _valor * multa;
}
