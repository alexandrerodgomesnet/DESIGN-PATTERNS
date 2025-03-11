namespace COMPOSITE.MODO_PADRAO;

public abstract class Componente
{
    public void Adicionar(Componente componente)
    {
        throw new UnsupportedOerationException();
    }

    public void Remover(Componente componente)
    {
        throw new UnsupportedOerationException();
    }

    public Componente RecuperarFilho(int indice) => throw new UnsupportedOerationException();

    public abstract void Exibir();

    public string GetNome() => throw new UnsupportedOerationException();

    public string GetCaminho() => throw new UnsupportedOerationException();
}