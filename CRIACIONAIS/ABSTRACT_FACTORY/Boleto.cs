namespace ABSTRACT_FACTORY;

public class Boleto
{
    private decimal _valor;
    private readonly IJuros _juros;
    private readonly IDesconto _desconto;
    private readonly IMulta _multa;

    public Boleto(decimal valor, ICalculosFactory factory)
    {
        _valor = valor;
        _desconto = factory.CriarDesconto();
        _juros = factory.CriarJuros();
        _multa = factory.CriarMulta();
    }

    public decimal CalcularDesconto() => _valor * _desconto.GetDesconto();

    public decimal CalcularJuros() => _valor * _juros.GetJuros();

     public decimal CalcularMulta() => _valor * _multa.GetMulta();
}