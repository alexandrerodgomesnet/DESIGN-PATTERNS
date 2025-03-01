namespace CHAIN_OF_RESPONSIBILITY.MODO_PADRAO;

public interface ICalculadorPontos
{
    int CalcularPontos(Pedido pedido);
    void SetProximo(ICalculadorPontos calculadorPontos);
}