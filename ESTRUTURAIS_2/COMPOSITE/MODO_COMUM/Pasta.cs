namespace COMPOSITE.MODO_COMUM;

public class Pasta
{
    private string _nome;
    private string _caminho;
    public List<Arquivo> _componentes;

    public Pasta(string nome, string caminho)
    {
        _nome = nome;
        _caminho = caminho;
        _componentes = [];
    }

    public void Adicionar(Arquivo componente)
    {
        _componentes.Add(componente);
    }

    public void Remover(Arquivo componente)
    {
        foreach (var item in _componentes)
        {
            if(componente == item)
            {
                _componentes.Remove(componente);
            }
        }
    }

    public Arquivo RecuperarFilho(int indice) => _componentes[indice];
    public string GetNome() => _nome;
    public string GetCaminho() => _caminho;
    public void Exibir()
    {
        Console.WriteLine($" - {GetNome()} - [ {GetCaminho()} ]");
        foreach (var item in _componentes)
        {
            item.Exibir();
        }
        Console.WriteLine($" ****************** ");
    }
}