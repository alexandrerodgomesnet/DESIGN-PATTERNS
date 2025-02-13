namespace FACTORY_METHOD.MODO_PADRAO_1;

public class BancoCaixaBoleto60Dias : Boleto
{
    public BancoCaixaBoleto60Dias(decimal valor) : base(valor)
    {
        juros = 0.10M;
        desconto = 0.0M;
        multa = 0.2M;
    }
}