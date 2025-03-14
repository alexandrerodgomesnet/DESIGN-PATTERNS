using Newtonsoft.Json;

namespace FLYWEIGHT.MODO_PADRAO;

public class EspecieFlyweight
{
    public string Nome {get; private set;}
    public string Cor {get; private set;}
    public decimal AlturaMaxima {get; private set;}

    public EspecieFlyweight(string nome, string cor, decimal alturaMaxima)
    {
        Nome = nome;
        Cor = cor;        
        AlturaMaxima = alturaMaxima;
    }

    public EspecieFlyweight RetornarEspecie() =>
        new(Nome, Cor, AlturaMaxima);

    public override string ToString() => JsonConvert.SerializeObject(this);
}