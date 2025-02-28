namespace CHAIN_OF_RESPONSIBILITY.MODO_COMUM;

public class CalculadoraPontos
{
    public int CalcularPontosPedido(Pedido pedido, int dias)
    {
        int pontos = 0;
        decimal valorPedido = pedido.GetValor();

        if(valorPedido >= 70)
            pontos = Convert.ToInt32(valorPedido / 5);
        else if(valorPedido >= 40)
            pontos = Convert.ToInt32(valorPedido / 7);
        else if(valorPedido >= 20)
            pontos = Convert.ToInt32(valorPedido / 10);
        else 
            return 0;

        if(dias >= 16 && dias <= 31)
            return pontos * 2;

        return pontos;
    }
}