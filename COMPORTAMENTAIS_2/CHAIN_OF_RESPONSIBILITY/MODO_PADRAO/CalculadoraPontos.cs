namespace CHAIN_OF_RESPONSIBILITY.MODO_PADRAO;

public class CalculadoraPontos
{
    public int CalcularPontos(Pedido pedido, int dias)
    {
        var ponto70 = new Pontos70Reais();
        var ponto40 = new Pontos40Reais();
        var ponto20 = new Pontos20Reais();
        var nenhumPonto = new NenhumPonto();

        ponto70.SetProximo(ponto40);
        ponto40.SetProximo(ponto20);
        ponto20.SetProximo(nenhumPonto);

        if(dias >= 16 && dias <= 31)
            return ponto70.CalcularPontos(pedido) * 2;

        return ponto70.CalcularPontos(pedido);
    }
}