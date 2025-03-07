namespace COMMAND.MODO_PADRAO;

public class DesligarArCondicionado : ICommand
{
    private ArCondicionado _arCondicionado;
    public DesligarArCondicionado(ArCondicionado arCondicionado)
    {
        _arCondicionado = arCondicionado;
    }

    public void Desfazer()
    {
        _arCondicionado.Ligar();
        _arCondicionado.ImprimeObjeto();
    }

    public void Executar()
    {
        _arCondicionado.Desligar();
        _arCondicionado.ImprimeObjeto();
    }
}