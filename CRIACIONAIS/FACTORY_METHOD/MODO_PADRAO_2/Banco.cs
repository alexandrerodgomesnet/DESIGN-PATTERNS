namespace FACTORY_METHOD.MODO_PADRAO_2;

public abstract class Banco
{
    protected abstract Boleto? CriarBoleto(int vencimentoBoleto, decimal valor);
    public Boleto? GerarBoleto(int vencimentoBoleto, decimal valor)
    {
        Boleto? boleto = CriarBoleto(vencimentoBoleto, valor);

        Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
        Console.WriteLine($"Valor Juros: {boleto?.CalcularJuros()}%");
        Console.WriteLine($"Valor Desconto R$ {boleto?.CalcularDesconto()}");
        Console.WriteLine($"Valor Multa R$ {boleto?.CalcularMulta()}");

        return boleto;
    }
}