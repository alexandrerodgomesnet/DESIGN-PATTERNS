using Newtonsoft.Json;

namespace FLYWEIGHT.MODO_PADRAO;

public class Arvore
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public EspecieFlyweight Especie { get; private set; }

    public Arvore(int x, int y, EspecieFlyweight especie)
    {
        X = x;
        Y = y;
        Especie = especie;
    }
    public Arvore RetornarArvore() => new(X, Y, Especie);
    public override string ToString() => JsonConvert.SerializeObject(this);
}