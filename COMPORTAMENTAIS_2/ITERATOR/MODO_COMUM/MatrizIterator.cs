namespace ITERATOR.MODO_COMUM;

public class MatrizIterator : IIterator<int>
{
    private List<List<int>> _matriz;
    private int _indiceLinha = 0;
    private int _indiceColuna = 0;
    private int _qtdeLinhas = 0;
    private int _qtdeColunas = 0;

    public MatrizIterator(List<List<int>> matriz)
    {
        _matriz = matriz;
        _qtdeLinhas = _matriz.Count;
        _qtdeColunas = _matriz[0].Count;
    }
    public bool HasNext() => _indiceLinha >= _qtdeLinhas ? false : true;

    public int Next()
    {
        var item = _matriz[_indiceLinha][_indiceColuna];

        if(_indiceColuna == _qtdeColunas - 1)
        {
            _indiceLinha = _indiceLinha + 1;
            _indiceColuna = 0;
        }
        else
            _indiceColuna = _indiceColuna + 1;

        return item;
    }
}