namespace STRATEGY.MODO_PADRAO;

public class FreteComum : IFrete
{
    public decimal Calcula(decimal valor)=> valor * Convert.ToDecimal(0.05);
}
