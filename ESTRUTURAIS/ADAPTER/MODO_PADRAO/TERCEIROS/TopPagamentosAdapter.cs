namespace ADAPTER.MODO_PADRAO.TERCEIROS;

public class TopPagamentosAdapter : IGateway
{
    private readonly TopPagamentos _topPagamentos;
    private string? _cvv = null;
    private string? _numeroCartao = null;

    public TopPagamentosAdapter(TopPagamentos topPagamentos)
    {
        _topPagamentos = topPagamentos;
    }

    public bool RealizarPagamento() => _topPagamentos.RealizarPagamento();

    public void SetCVV(string cvv)
    {
        _cvv = cvv;
        if(!string.IsNullOrWhiteSpace(_numeroCartao))
            _topPagamentos.SetCartao(_numeroCartao, cvv);
    }

    public void SetNumeroCartao(string numeroCartao)
    {
        _numeroCartao = numeroCartao;
        if(!string.IsNullOrWhiteSpace(_cvv))
            _topPagamentos.SetCartao(numeroCartao, _cvv);
    }

    public void SetParcelas(int parcelas) => _topPagamentos.SetQuantidadeParcelas(parcelas);

    public void SetValor(decimal valor) => _topPagamentos.SetValorTotal(valor);

    public bool ValidarCartao()
    {
        throw new NotImplementedException();
    }
}
