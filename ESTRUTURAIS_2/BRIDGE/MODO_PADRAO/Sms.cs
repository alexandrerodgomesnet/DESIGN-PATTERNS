namespace BRIDGE.MODO_PADRAO;

public class Sms : ICanalEnvio
{
    public void EnviarMensagem(string assunto, string mensagem)
    {
        
        Console.WriteLine("#### Mensagem Enviada por SMS ####");
        Console.WriteLine($"Assunto: {assunto}");        
        Console.WriteLine($"Mensagem: {mensagem}");
        Console.WriteLine();
    }
}