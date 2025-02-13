namespace FACTORY_METHOD.MODO_PADRAO_2.BB;

public class BancoBrasilBoleto60Dias : Boleto
{
    public BancoBrasilBoleto60Dias(decimal valor) : base(valor)
    {
        juros = 0.10M;
        desconto = 0.0M;
        multa = 0.15M;
    }
}