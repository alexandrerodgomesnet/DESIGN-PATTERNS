namespace ABSTRACT_FACTORY.Caixa;

public class CaixaDesconto : IDesconto
{
    public decimal GetDesconto() => 0.1M;
}