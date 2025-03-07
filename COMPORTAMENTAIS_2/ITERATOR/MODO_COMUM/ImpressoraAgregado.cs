namespace ITERATOR.MODO_COMUM;

public static class ImpressoraAgregado<T>
{
    public static void Iterar(IIterator<T> iterator)
    {
        while (iterator.HasNext())
        {
            Console.WriteLine($"{iterator.Next()} ");            
        }
    }
}