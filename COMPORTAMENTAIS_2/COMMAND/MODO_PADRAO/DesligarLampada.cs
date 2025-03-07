namespace COMMAND.MODO_PADRAO;

public class DesligarLampada : ICommand
{
    private Lampada _lampada;
    public DesligarLampada(Lampada lampada)
    {
        _lampada = lampada;
    }

    public void Desfazer()
    {
        _lampada.Ligar();
        _lampada.ImprimeObjeto();
    }

    public void Executar()
    {
        _lampada.Desligar();
        _lampada.ImprimeObjeto();
    }
}