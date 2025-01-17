namespace STRATEGY.MODO_PADRAO;

public class FreteExpresso : IFrete
{
    public decimal Calcula(decimal valor)=> valor * Convert.ToDecimal(0.1);
}
