namespace COMMAND.MODO_PADRAO;

public class Aplicativo
{
    private List<ICommand> _comandos = [];

    public int SetCommando(ICommand comando)
    {
        _comandos.Add(comando);
        return _comandos.Count - 1;
    }

    public void AoPrecionarBotao(int id)
    {
        _comandos[id].Executar();
    }

    public void DuploCliqueBotao(int id)
    {
        _comandos[id].Desfazer();
    }

    public ICommand GetComando(int id) => _comandos[id];
}