namespace ITERATOR.MODO_PADRAO;

public class Matriz : IAgregado<int>
{
    private int[,] _matriz;
    private int _linhaAtual = 0;
    private int _colunaAtual = 0;
    private int _qtdeLinhas = 0;
    private int _qtdeColunas = 0;

    public Matriz(int qtdeLinhas, int qtdeColunas)
    {
        _qtdeLinhas = qtdeLinhas;
        _qtdeColunas = qtdeColunas;
        _matriz = new int[_qtdeLinhas, _qtdeColunas];
    }

    public bool AddItem(int item)
    {
        if(_linhaAtual == (_qtdeLinhas - 1) && _colunaAtual == _qtdeColunas)
            return false;

        if(_colunaAtual == _qtdeColunas)
        {
            _linhaAtual = _linhaAtual + 1;
            _colunaAtual = 0;
        }         

        _matriz[_linhaAtual, _colunaAtual] = item;
        _colunaAtual = _colunaAtual + 1;
        return true;
    }
    public int GetItem(int linha, int coluna) => _matriz[linha, coluna];
    public int GetQtdeLinhas() => _qtdeLinhas;
    public int GetQtdeColunas() => _qtdeColunas;
    public IIterator<int> CreateIterator() => new MatrizIterator(this);
}