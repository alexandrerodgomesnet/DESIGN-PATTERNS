namespace ITERATOR.MODO_COMUM;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}