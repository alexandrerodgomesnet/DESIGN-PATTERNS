namespace FLYWEIGHT.MODO_COMUM;

public class Arvore
{
    private int _x;
    private int _y;
    private string _nome;
    private string _cor;
    private int _alturaMaxima;

    public Arvore(int x, int y, string nome, string cor, int alturaMaxima)
    {
        _x = x;
        _y = y;
        _nome = nome;
        _cor = cor;
        _alturaMaxima = alturaMaxima;
    }

    public Arvore RetornarArvore() =>
        new(_x, _y, _nome, _cor, _alturaMaxima);

    public override string ToString() =>
        $"X: {_x}; Y: {_y}; Nome: {_nome}; Cor: {_cor}; Altura Máxima: {_alturaMaxima}";
}