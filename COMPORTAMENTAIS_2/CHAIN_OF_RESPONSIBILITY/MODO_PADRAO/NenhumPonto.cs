namespace CHAIN_OF_RESPONSIBILITY.MODO_PADRAO;

public class NenhumPonto : ICalculadorPontos
{
    public int CalcularPontos(Pedido pedido) => 0;

    public void SetProximo(ICalculadorPontos calculadorPontos) 
    {

    }
}