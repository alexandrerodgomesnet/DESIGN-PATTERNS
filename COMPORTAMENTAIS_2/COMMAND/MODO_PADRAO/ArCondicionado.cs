namespace COMMAND.MODO_PADRAO;

public class ArCondicionado
{
    private string _identificacao;
    private bool _estado;
    private int _temperatura;

    public ArCondicionado(string identificacao, bool estado, int temperatura)
    {
        _identificacao = identificacao;
        _estado = estado;
        _temperatura = temperatura;
    }

    public void Ligar() => _estado = true;
    public void Desligar() => _estado = false;
    public void SetTempeartura(int temperatura) => _temperatura = temperatura;
    public string GetIdentificacao() => _identificacao;
    public bool GetEstado() => _estado;
    public int GetTemperatura() => _temperatura;
    public void ImprimeObjeto()
    {
        var descricaoImpessao = "";
        if(_estado)
            descricaoImpessao = $"O objeto {_identificacao} está Ligado a {_temperatura} graus celsius";
        else
            descricaoImpessao = $"O objeto {_identificacao} está Desligado.";
        
        Console.WriteLine(descricaoImpessao);
    }
}