namespace ITERATOR.MODO_PADRAO;

public interface IAgregado<T>
{
    IIterator<T> CreateIterator();
}
