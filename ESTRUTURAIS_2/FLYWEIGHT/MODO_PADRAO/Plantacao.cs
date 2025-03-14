using Microsoft.VisualBasic;

namespace FLYWEIGHT.MODO_PADRAO;

public class Plantacao
{
    private readonly List<Arvore> _arvores;
    private readonly EspecieFabrica _especieFabrica;

    public Plantacao()
    {
        _arvores = [];
        _especieFabrica = new();
    }

    public void AdicionarArvore(int x, int y, string nome, string cor, 
        decimal alturaMaxima)
    {
        var especie = _especieFabrica.GetEspecie(nome, cor, alturaMaxima);
        _arvores.Add(new Arvore(x, y, especie));
    }
        
    public List<EspecieFlyweight> RetornarEspecies()
    {
        var listaEspecies = new List<EspecieFlyweight>();
        var especies = _especieFabrica.RetornarEspecies();
        foreach (var item in especies)
        {
            var especie = item.RetornarEspecie();
            listaEspecies.Add(especie);
        }

        return listaEspecies;
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