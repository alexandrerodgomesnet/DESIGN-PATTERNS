namespace VISITOR.MODO_PADRAO;

public static class ExtensionsVisitor
{
    public static decimal CalcularLucroSupermercado(this Supermercado supermercado) =>
        SomarLucroSupermercado(supermercado);

    private static Func<Supermercado, decimal> SomarLucroSupermercado =
        s => s.GetDepartamentos()
        .Sum(CalcularLucroDepartamento!);

    public static decimal CalcularLucroProduto(this Produto produto) =>
        SomarLucroProduto(produto);

    private static Func<Produto, decimal> SomarLucroProduto =
        p => (p.GetPreco() * p.GetMargemLucro()) / 100;

    public static decimal CalcularLucroDepartamento(this Departamento departamento) =>
        SomarLucroDepartamento(departamento);

    private static Func<Departamento, decimal> SomarLucroDepartamento =
        d => d.GetProdutos()
            .Sum(CalcularLucroProduto);
}