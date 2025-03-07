namespace COMMAND.MODO_PADRAO;

public class LigarArCondicionado : ICommand
{
    private ArCondicionado _arCondicionado;
    public LigarArCondicionado(ArCondicionado arCondicionado)
    {
        _arCondicionado = arCondicionado;
    }

    public void Desfazer()
    {
        _arCondicionado.Desligar();
        _arCondicionado.ImprimeObjeto();
    }

    public void Executar()
    {
        _arCondicionado.Ligar();
        _arCondicionado.ImprimeObjeto();
    }
}