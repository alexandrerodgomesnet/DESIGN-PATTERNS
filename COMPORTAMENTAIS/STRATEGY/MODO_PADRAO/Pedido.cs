using STRATEGY.MODO_PADRAO;

public abstract class Pedido
{
    private decimal _valor;
    private IFrete _tipoFrete;

    public decimal GetValor() => _valor;
    public void SetValor(decimal valor) => _valor = valor;
    public void SetTipoFrete(IFrete tipoFrete) => _tipoFrete = tipoFrete;
    public decimal CalcularFrete() => _tipoFrete.Calcula(_valor);
    // public abstract decimal CalcularFreteComum();
    // public abstract decimal CalcularFreteExpresso();
}