namespace FACTORY_METHOD.MODO_PADRAO_1;

public class BoletoSimpleFactory
{
    public Boleto? CriarBoleto(int vencimentoBoleto, decimal valor)
    {
        Boleto? boleto = null;
        switch (vencimentoBoleto)
        {
            case 10:
                boleto = new BancoCaixaBoleto10Dias(valor);
            break;
            case 30:
                boleto = new BancoCaixaBoleto30Dias(valor);
            break;
            case 60:
                boleto = new BancoCaixaBoleto60Dias(valor);
            break;
        }

        return boleto;
    }
}