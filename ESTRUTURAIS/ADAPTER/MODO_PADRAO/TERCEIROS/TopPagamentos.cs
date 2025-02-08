namespace ADAPTER.MODO_PADRAO.TERCEIROS;

public class TopPagamentos
{
    private decimal _valor;
    private int _parcelas;
    private string _numeroCartao = string.Empty;
    private string _cvv = string.Empty;

    public void SetValorTotal(decimal valor) => _valor = valor;
    public void SetQuantidadeParcelas(int parcelas) => _parcelas = parcelas;
    public void SetCartao(string numeroCartao, string cvv)
    {
        _numeroCartao = numeroCartao;
        _cvv = cvv;
    }

    public bool RealizarPagamento()
    {
        Console.WriteLine("Pagamento realizado via Top pagamentos.");
        return true;
    }
}
