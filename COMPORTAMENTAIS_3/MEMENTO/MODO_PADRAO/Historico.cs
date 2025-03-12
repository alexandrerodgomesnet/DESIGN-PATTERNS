namespace MEMENTO.MODO_PADRAO;

public class Historico
{
    private List<IMemento> _historico = [];

    public void CriarCheckPoint(IOriginador originador)
    {
        _historico.Add(originador.Salvar());
    }

    public void Desfazer()
    {
        if(_historico.Count <= 0)
            return;

        var memento = _historico.LastOrDefault();
        memento.Restaurar();
    }

    public void Imprimir(IOriginador originador) => originador.Imprimir();
}