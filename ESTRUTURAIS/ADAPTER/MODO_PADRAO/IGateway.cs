namespace ADAPTER.MODO_PADRAO;

public interface IGateway
{
    void SetValor(decimal valor);
    void SetParcelas(int parcelas);
    void SetNumeroCartao(string numeroCartao);
    void SetCVV(string cvv);
    bool ValidarCartao();
    bool RealizarPagamento();
}
