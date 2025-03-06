namespace ITERATOR.MODO_COMUM;

public class ListaIterator : IIterator<int>
{
    private List<int> _lista;
    private int _indice = 0;
    private int  _tamanho;

    public ListaIterator(List<int> lista)
    {
        _lista = lista;
        _tamanho = _lista.Count;
    }
    public bool hasNext() => _indice < _tamanho;

    public int Next()
    {
        var item = _lista[_indice];
        _indice = _indice + 1;
        return item;
    }
}
