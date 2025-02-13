namespace FACTORY_METHOD.MODO_PADRAO_1;

public class BancoCaixa
{
    private readonly BoletoSimpleFactory _factory;

    public BancoCaixa(BoletoSimpleFactory factory)
    {
        _factory = factory;
    }

    public Boleto? GerarBoleto(int vencimentoBoleto, decimal valor)
    {
        Boleto? boleto = _factory.CriarBoleto(vencimentoBoleto, valor);

        Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
        Console.WriteLine($"Valor Juros: {boleto?.CalcularJuros()}%");
        Console.WriteLine($"Valor Desconto R$ {boleto?.CalcularDesconto()}");
        Console.WriteLine($"Valor Multa R$ {boleto?.CalcularMulta()}");

        return boleto;
    }
}
