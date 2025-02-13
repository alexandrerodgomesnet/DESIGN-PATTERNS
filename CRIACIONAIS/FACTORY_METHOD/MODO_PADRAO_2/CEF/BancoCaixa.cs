namespace FACTORY_METHOD.MODO_PADRAO_2.CEF;

public class BancoCaixa : Banco
{
    protected override Boleto? CriarBoleto(int vencimentoBoleto, decimal valor)
    {
        return vencimentoBoleto switch
        {
            10 => new BancoCaixaBoleto10Dias(valor),
            30 => new BancoCaixaBoleto30Dias(valor),
            60 => new BancoCaixaBoleto60Dias(valor),
            _ => throw new Exception("Vencimento indisponivel."),
        };
    }
}