namespace TEMPLATE_METHOD.MODO_PADRAO;

public class Gateway
{
    public bool Cobrar(decimal valor)
    {
        Console.WriteLine(valor);
        Console.WriteLine("");

        Random random = new();
        return random.Next(0, 1) == 0;
    }
}