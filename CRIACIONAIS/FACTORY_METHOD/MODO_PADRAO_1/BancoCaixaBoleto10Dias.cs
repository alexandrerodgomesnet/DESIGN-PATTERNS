namespace FACTORY_METHOD.MODO_PADRAO_1;

public class BancoCaixaBoleto10Dias : Boleto
{
    public BancoCaixaBoleto10Dias(decimal valor) : base(valor)
    {
        juros = 0.02M;
        desconto = 0.1M;
        multa = 0.05M;
    }
}