namespace VISITOR.MODO_PADRAO;

public interface IVisitor
{
    decimal VisitorSupermercado(Supermercado supermercado);
    decimal VisitorDepartamento(Departamento departamento);
    decimal VisitorProduto(Produto produto);
}