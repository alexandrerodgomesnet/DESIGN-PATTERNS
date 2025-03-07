namespace ITERATOR.MODO_PADRAO;

public class ListaIterator : IIterator<int>
{
    private Lista _lista;
    private int _indice = 0;
    private int  _tamanho;

    public ListaIterator(Lista lista)
    {
        _lista = lista;
        _tamanho = _lista.GetTamanho();
    }
    public bool HasNext() => _indice < _tamanho;

    public int Next()
    {
        var item = _lista.GetItem(_indice);
        _indice = _indice + 1;
        return item;
    }
}