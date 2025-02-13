namespace FACTORY_METHOD.MODO_PADRAO_2.BB;

public class BancoBrasilBoleto30Dias : Boleto
{
    public BancoBrasilBoleto30Dias(decimal valor) : base(valor)
    {
        juros = 0.05M;
        desconto = 0.02M;
        multa = 0.05M;
    }
}
