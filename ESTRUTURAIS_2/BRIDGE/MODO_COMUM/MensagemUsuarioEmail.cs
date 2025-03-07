namespace BRIDGE.MODO_COMUM;

public class MensagemUsuarioEmail : Mensagem
{
    public override void Enviar()
    {
        Console.WriteLine("Mensagem Enviada pelo USUARIO");
        Console.WriteLine("#### Mensagem Enviada por Email ####");
        Console.WriteLine($"Assunto: {_assunto}");
        Console.WriteLine($"Mensagem: {_mensagem}");
        Console.WriteLine();
    }
}