namespace CHAIN_OF_RESPONSIBILITY.MODO_PADRAO;

public class Pontos20Reais : ICalculadorPontos
{
    private ICalculadorPontos? _calculadorPontos;
    public int CalcularPontos(Pedido pedido)
    {
        decimal valorPedido = pedido.GetValor();

        if(valorPedido >= 20)
            return Convert.ToInt32(valorPedido / 10);
            
        return _calculadorPontos.CalcularPontos(pedido);
    }

    public void SetProximo(ICalculadorPontos calculadorPontos) =>_calculadorPontos = calculadorPontos;
}
