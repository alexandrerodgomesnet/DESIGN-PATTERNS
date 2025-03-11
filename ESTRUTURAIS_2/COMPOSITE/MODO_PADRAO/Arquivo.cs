namespace COMPOSITE.MODO_PADRAO;

public class Arquivo : Componente
{
    private string _nome;
    private string _caminho;

    public Arquivo(string nome, string caminho)// : base(nome, caminho)
    {
        _nome = nome;
        _caminho = caminho;
    }

    public new string GetNome() => _nome;
    public new string GetCaminho() => _caminho;
    public override void Exibir()
    {
        Console.WriteLine($"    - {GetNome()} - [ {GetCaminho()} ]");
    }
}