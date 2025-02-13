namespace DECORATOR.MODO_PADRAO;

public class BordaRequeijao : AcrescimoDecorator
{
    public BordaRequeijao(Pizza pizza) : base(pizza)
    {
    }

    public override string GetDescricao() => $"{_pizza.GetDescricao() } + Borda recheada de requeijão";
    public override decimal GetPreco() => _pizza.GetPreco() + 8.50M;
}