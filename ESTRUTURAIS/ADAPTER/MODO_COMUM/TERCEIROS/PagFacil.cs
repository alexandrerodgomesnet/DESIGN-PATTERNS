namespace ADAPTER.MODO_COMUM.TERCEIROS;

public class PagFacil
{
    private decimal _valor;
    private int _parcelas;
    private string _numeroCartao = string.Empty;
    private string _cvv = string.Empty;

    public void SetValor(decimal valor) => _valor = valor;
    public void SetParcelas(int parcelas) => _parcelas = parcelas;
    public void SetNumeroCartao(string numeroCartao) => _numeroCartao = numeroCartao;
    public void SetCVV(string cvv) => _cvv = cvv;

    public bool ValidarCartao()
    {
        if(!string.IsNullOrWhiteSpace(_numeroCartao) &&
            !string.IsNullOrEmpty(_cvv) && _cvv.Length == 3)
            return true;

        return false;
    }

    public bool RealizarPagamento()
    {
        Console.WriteLine("Pagamento realizado via PagFacil.");
        return true;
    }
}
