namespace ITERATOR.MODO_PADRAO;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}