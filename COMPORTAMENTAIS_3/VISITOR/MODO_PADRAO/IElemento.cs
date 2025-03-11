namespace VISITOR.MODO_PADRAO;

public interface IElemento
{
    decimal Aceitar(IVisitor visitor);
}