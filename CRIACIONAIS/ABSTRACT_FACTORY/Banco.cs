namespace ABSTRACT_FACTORY;

public class Banco
{
    public Boleto? GerarBoleto(decimal valor, ICalculosFactory factory)
    {
        Boleto? boleto = new(valor, factory);

        Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
        Console.WriteLine($"Valor Juros: {boleto?.CalcularJuros()}%");
        Console.WriteLine($"Valor Desconto R$ {boleto?.CalcularDesconto()}");
        Console.WriteLine($"Valor Multa R$ {boleto?.CalcularMulta()}");

        return boleto;
    }
}