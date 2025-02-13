namespace FACTORY_METHOD.MODO_COMUM;

public class BancoCaixa
{
    public Boleto GerarBoleto(int vencimentoBoleto, decimal valor)
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

        Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
        Console.WriteLine($"Valor Juros: {boleto?.CalcularJuros()}%");
        Console.WriteLine($"Valor Desconto R$ {boleto?.CalcularDesconto()}");
        Console.WriteLine($"Valor Multa R$ {boleto?.CalcularMulta()}");

        return boleto;
    }
}
