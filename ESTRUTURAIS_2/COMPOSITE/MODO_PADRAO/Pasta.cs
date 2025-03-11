namespace COMPOSITE.MODO_PADRAO;

public class Pasta : Componente
{
    private string _nome;
    private string _caminho;
    private List<Componente> _componentes;
    public Pasta(string nome, string caminho)
    {
        _nome = nome;
        _caminho = caminho;
        _componentes = [];
    }

    public new void Adicionar(Componente componente)
    {
        _componentes.Add(componente);
    }

    public new void Remover(Componente componente)
    {
        foreach (var item in _componentes)
        {
            if(componente == item)
            {
                _componentes.Remove(item);
            }
        }
    }

    public new Componente RecuperarFilho(int indice) => _componentes[indice];
    public new string GetNome() => _nome;
    public new string GetCaminho() => _caminho;
    public override void Exibir()
    {
        Console.WriteLine($" ## {GetNome()} - [ {GetCaminho()} ] ##");
        Console.WriteLine($" ------------------------------ ");

        foreach (var item in _componentes)
        {
            item.Exibir();
        }
        Console.WriteLine();
    }
}