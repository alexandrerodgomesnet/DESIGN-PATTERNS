namespace DECORATOR.MODO_PADRAO;

public class PizzaFrango : Pizza
{
    public PizzaFrango() => _descricao = "Deliciosa pizza de frango";
    public override string GetDescricao() => _descricao;
    public override decimal GetPreco() => 19M;
}