namespace COMMAND.MODO_PADRAO;

public class MudarTemperaturaArCondicionado : ICommand
{
    private ArCondicionado _arCondicionado;
    private int _temperatura;
    private int _temperaturaAnterior;
    public MudarTemperaturaArCondicionado(ArCondicionado arCondicionado)
    {
        _arCondicionado = arCondicionado;
        _temperatura = _arCondicionado.GetTemperatura();
        _temperaturaAnterior = _temperatura;
    }

    public void SetTempeartura(int temperatura)
    {
        _temperaturaAnterior = _temperatura;
        _temperatura = temperatura;
    }

    public void Desfazer()
    {
        _arCondicionado.SetTempeartura(_temperaturaAnterior);
        _arCondicionado.ImprimeObjeto();
    }

    public void Executar()
    {
        _arCondicionado.SetTempeartura(_temperatura);
        _arCondicionado.ImprimeObjeto();
    }
}