namespace DECORATOR.MODO_PADRAO;

public class PizzaCalabreza : Pizza
{
    public PizzaCalabreza() => _descricao = "Deliciosa pizza de calabreza";
    public override string GetDescricao() => _descricao;
    public override decimal GetPreco() => 25M;
}