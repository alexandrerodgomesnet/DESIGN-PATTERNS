namespace FACTORY_METHOD.MODO_PADRAO_2.CEF;

public class BancoCaixaBoleto30Dias : Boleto
{
    public BancoCaixaBoleto30Dias(decimal valor) : base(valor)
    {
        juros = 0.05M;
        desconto = 0.05M;
        multa = 0.1M;
    }
}
