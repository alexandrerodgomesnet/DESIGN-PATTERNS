namespace FLYWEIGHT.MODO_PADRAO;

public class EspecieFabrica
{
    private List<EspecieFlyweight> _especies = [];

    public EspecieFlyweight GetEspecie(string nome, string cor, decimal alturaMaxima)
    {
        foreach (var item in _especies)
        {
            if(item.Nome == nome && item.Cor == cor && item.AlturaMaxima == alturaMaxima)
                return item;
        }

        var especie = new EspecieFlyweight(nome, cor, alturaMaxima);
        _especies.Add(especie);

        return especie;
    }

    public List<EspecieFlyweight> RetornarEspecies() => _especies;
}