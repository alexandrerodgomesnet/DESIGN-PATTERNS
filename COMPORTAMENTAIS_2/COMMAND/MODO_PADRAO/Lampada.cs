namespace COMMAND.MODO_PADRAO;

public class Lampada
{
    private string _identificacao;
    private bool _estado;

    public Lampada(string identificacao, bool estado)
    {
        _identificacao = identificacao;
        _estado = estado;
    }

    public void Ligar() => _estado = true;
    public void Desligar() => _estado = false;
    public string GetIdentificacao() => _identificacao;
    public bool GetEstado() => _estado;
    public void ImprimeObjeto()
    {
        var descricaoImpessao = "";
        if(_estado)
            descricaoImpessao = $"O objeto {_identificacao} está Ligado";
        else
            descricaoImpessao = $"O objeto {_identificacao} está Desligado";
        Console.WriteLine(descricaoImpessao);
    }
}