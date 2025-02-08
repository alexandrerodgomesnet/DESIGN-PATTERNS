using ADAPTER.MODO_COMUM.TERCEIROS;

namespace ADAPTER.MODO_PADRAO;

public class Cobranca
{
    private IGateway _gateway;
    public Cobranca(IGateway gateway)
    {
        _gateway = gateway;
    }

    public void SetGateway(IGateway gateway)
    {
        _gateway = gateway;
    }

    public void SetValor(decimal valor)
    {
        _gateway.SetValor(valor);
    }

    public void SetParcelas(int parcelas)
    {
        _gateway.SetParcelas(parcelas);
    }

    public void SetNumeroCartao(string numeroCartao)
    {
        _gateway.SetNumeroCartao(numeroCartao);
    }

    public void SetCVV(string cvv)
    {
        _gateway.SetCVV(cvv);
    }

    public bool RealizarPagamento() =>_gateway.RealizarPagamento();
}
