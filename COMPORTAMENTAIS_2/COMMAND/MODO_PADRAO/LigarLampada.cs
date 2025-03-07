namespace COMMAND.MODO_PADRAO;

public class LigarLampada : ICommand
{
    private Lampada _lampada;
    public LigarLampada(Lampada lampada)
    {
        _lampada = lampada;
    }

    public void Desfazer()
    {
        _lampada.Desligar();
        _lampada.ImprimeObjeto();
    }

    public void Executar()
    {
        _lampada.Ligar();
        _lampada.ImprimeObjeto();
    }
}