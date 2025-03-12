namespace MEMENTO.MODO_PADRAO;

public interface IOriginador
{
    IMemento Salvar();
    void Imprimir();
}