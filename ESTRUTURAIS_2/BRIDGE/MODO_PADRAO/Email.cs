namespace BRIDGE.MODO_PADRAO;

public class Email : ICanalEnvio
{
    public void EnviarMensagem(string assunto, string mensagem)
    {
        
        Console.WriteLine("#### Mensagem Enviada por Email ####");
        Console.WriteLine($"Assunto: {assunto}");
        Console.WriteLine($"Mensagem: {mensagem}");
        Console.WriteLine();
    }
}