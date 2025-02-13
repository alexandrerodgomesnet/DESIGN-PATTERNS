namespace FACTORY_METHOD.MODO_PADRAO_2.BB;

public class BancoBrasil : Banco
{
    protected override Boleto? CriarBoleto(int vencimentoBoleto, decimal valor)
    {
        return vencimentoBoleto switch
        {
            10 => new BancoBrasilBoleto10Dias(valor),
            30 => new BancoBrasilBoleto30Dias(valor),
            60 => new BancoBrasilBoleto60Dias(valor),
            _ => throw new Exception("Vencimento indisponivel."),
        };
    }
}