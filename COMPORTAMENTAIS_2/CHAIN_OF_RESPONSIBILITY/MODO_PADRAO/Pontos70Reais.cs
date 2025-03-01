namespace CHAIN_OF_RESPONSIBILITY.MODO_PADRAO;

public class Pontos70Reais : ICalculadorPontos
{
    private ICalculadorPontos? _calculadorPontos;
    public int CalcularPontos(Pedido pedido)
    {
        decimal valorPedido = pedido.GetValor();

        if(valorPedido >= 70)
            return Convert.ToInt32(valorPedido / 5);

        return _calculadorPontos.CalcularPontos(pedido);
    }

    public void SetProximo(ICalculadorPontos calculadorPontos) =>_calculadorPontos = calculadorPontos;
}
