namespace PROTOTYPE.MODO_PADRAO;

public class Revista : IPrototype
{
    private string _nome = string.Empty;
    private int _edicao;

    public string GetNome() => _nome;
    public void SetNome(string nome) => _nome = nome;
    public int GetEdicao() => _edicao;
    public void SetEdicao(int edicao) => _edicao = edicao;
    
    public override string ToString() =>
        $"Nome: {_nome}; Edição: {_edicao};";

    public IPrototype Clone()
    {
        var revista = new Revista();        
        revista.SetNome(_nome);
        revista.SetEdicao(_edicao);
        return revista;
    }
}