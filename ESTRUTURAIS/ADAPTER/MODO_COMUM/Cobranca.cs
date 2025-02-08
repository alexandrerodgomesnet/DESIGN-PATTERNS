using ADAPTER.MODO_COMUM.TERCEIROS;

namespace ADAPTER.MODO_COMUM;

public class Cobranca
{
    private PagFacil _gateway;
    public Cobranca(PagFacil gateway)
    {
        _gateway = gateway;
    }

    public void SetGateway(PagFacil gateway)
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
