namespace ABSTRACT_FACTORY.BancoBrasil;

public class BancoBrasilDesconto : IDesconto
{
    public decimal GetDesconto() => 0.05M;
}