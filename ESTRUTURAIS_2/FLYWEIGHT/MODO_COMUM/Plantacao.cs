namespace FLYWEIGHT.MODO_COMUM;

public class Plantacao
{
    private List<Arvore> _arvores = [];

    public void AdicionarArvore(int x, int y, string nome, 
        string cor, int alturaMaxima)
    {
        var arvore = new Arvore(x, y, nome, cor, alturaMaxima);
        _arvores.Add(arvore);
    }

    public List<Arvore> RetornarAvores()
    {
        var arvores = new List<Arvore>();
        foreach (var item in _arvores)
        {
            arvores.Add(item.RetornarArvore());
        }

        return arvores;
    }
}