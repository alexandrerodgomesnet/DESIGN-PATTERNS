namespace ITERATOR.MODO_PADRAO;

public class Lista : IAgregado<int>
{
    private List<int> _lista = [];
    private int _tamanho;
    
    public Lista(int tamanho)
    {
        _tamanho = tamanho;
    }

    public bool AddItem(int item)
    {
        if(_lista.Count < _tamanho)
        {
            _lista.Add(item);
            return true;
        }

        return false;
    }
    public int GetItem(int indice) => _lista[indice];
    public int GetTamanho() => _tamanho;

    public IIterator<int> CreateIterator() => new ListaIterator(this);
}