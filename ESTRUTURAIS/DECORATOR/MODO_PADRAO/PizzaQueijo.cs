namespace DECORATOR.MODO_PADRAO;

public class PizzaQueijo : Pizza
{
    public PizzaQueijo() => _descricao = "Deliciosa pizza de queijo";
    public override string GetDescricao() => _descricao;
    public override decimal GetPreco() => 22M;
}