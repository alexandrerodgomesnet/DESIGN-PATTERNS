namespace ITERATOR.MODO_PADRAO;

public class MatrizIterator : IIterator<int>
{
    private Matriz _matriz;
    private int _indiceLinha = 0;
    private int _indiceColuna = 0;
    private int _qtdeLinhas = 0;
    private int _qtdeColunas = 0;

    public MatrizIterator(Matriz matriz)
    {
        _matriz = matriz;
        _qtdeLinhas = _matriz.GetQtdeLinhas();
        _qtdeColunas = _matriz.GetQtdeColunas();
    }
    public bool HasNext() => _indiceLinha >= _qtdeLinhas ? false : true;

    public int Next()
    {
        var item = _matriz.GetItem(_indiceLinha, _indiceColuna);

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