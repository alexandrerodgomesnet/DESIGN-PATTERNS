namespace ITERATOR.MODO_PADRAO;

public static class ImpressoraAgregado<T>
{
    public static void Iterar(IAgregado<T> agregado)
    {
        var iterator = agregado.CreateIterator();
        while (iterator.HasNext())
        {
            Console.WriteLine($"{iterator.Next()} ");            
        }
    }
}