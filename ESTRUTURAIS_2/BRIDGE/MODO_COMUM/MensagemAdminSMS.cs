namespace BRIDGE.MODO_COMUM;

public class MensagemAdminSMS : Mensagem
{
    public override void Enviar()
    {
        Console.WriteLine("Mensagem Enviada pelo ADMINISTRADOR");
        Console.WriteLine("#### Mensagem Enviada por SMS ####");
        Console.WriteLine($"Assunto: {_assunto}");        
        Console.WriteLine($"Mensagem: {_mensagem}");
        Console.WriteLine();
    }
}