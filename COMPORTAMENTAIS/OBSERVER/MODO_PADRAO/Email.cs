namespace OBSERVER.MODO_PADRAO;

public class Email
{
    public static void Enviar(IObserver observer, string mensagem)
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Email enviado para: {observer.GetNome()} - {observer.GetEmail()}");
        Console.WriteLine($"Mensagem: {mensagem}");
    }
}