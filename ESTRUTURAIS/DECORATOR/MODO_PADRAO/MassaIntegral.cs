namespace DECORATOR.MODO_PADRAO;

public class MassaIntegral : AcrescimoDecorator
{
    public MassaIntegral(Pizza pizza) : base(pizza)
    {
    }

    public override string GetDescricao() => $"{_pizza.GetDescricao() } + Massa integral";
    public override decimal GetPreco() => _pizza.GetPreco() + 5.00M;
}