namespace COMPOSITE.MODO_COMUM;

public class Arquivo
{
    private string _nome;
    private string _caminho;

    public Arquivo(string nome, string caminho)
    {
        _nome = nome;
        _caminho = caminho;
    }

    public string GetNome() => _nome;
    public string GetCaminho() => _caminho;
    public void Exibir()
    {
        Console.WriteLine($" - {GetNome()} - [ {GetCaminho()} ]");
    }
}