namespace ITERATOR.MODO_COMUM;

public interface IIterator<T>
{
    bool hasNext();
    T Next();
}