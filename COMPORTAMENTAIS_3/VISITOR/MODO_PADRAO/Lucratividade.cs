namespace VISITOR.MODO_PADRAO;


public class Lucratividade : IVisitor
{
    public decimal VisitorDepartamento(Departamento departamento) =>
        departamento.CalcularLucroDepartamento();

    public decimal VisitorProduto(Produto produto) =>
        produto.CalcularLucroProduto();

    public decimal VisitorSupermercado(Supermercado supermercado) =>
        supermercado.CalcularLucroSupermercado();

    // private static Func<Supermercado, decimal> CalcularLucroSupermercado =
    //     s => s.GetDepartamentos()
    //     .Sum(CalcularLucroDepartamento!);

    // private static Func<Produto, decimal> CalcularLucroProduto =
    //     p => (p.GetPreco() * p.GetMargemLucro()) / 100;

    // private static Func<Departamento, decimal> CalcularLucroDepartamento =
    //     d => d.GetProdutos()
    //         .Sum(CalcularLucroProduto);
}
