namespace FACTORY_METHOD.MODO_PADRAO_2.BB;

public class BancoBrasilBoleto10Dias : Boleto
{
    public BancoBrasilBoleto10Dias(decimal valor) : base(valor)
    {
        juros = 0.03M;
        desconto = 0.05M;
        multa = 0.02M;
    }
}