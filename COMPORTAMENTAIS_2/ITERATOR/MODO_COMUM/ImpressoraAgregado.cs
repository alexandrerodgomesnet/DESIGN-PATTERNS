namespace ITERATOR.MODO_COMUM;

public static class ImpressoraAgregado<T>
{
    public static void Iterar(IIterator<T> iterator)
    {
        while (iterator.hasNext())
        {
            Console.WriteLine($"{iterator.Next()} ");            
        }
    }
}