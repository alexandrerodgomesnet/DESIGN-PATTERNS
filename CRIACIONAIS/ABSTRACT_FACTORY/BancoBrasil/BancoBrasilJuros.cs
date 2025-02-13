namespace ABSTRACT_FACTORY.BancoBrasil;

public class BancoBrasilJuros : IJuros
{
    public decimal GetJuros() => 0.03M;
}