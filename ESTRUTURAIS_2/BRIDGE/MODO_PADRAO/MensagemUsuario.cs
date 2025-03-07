namespace BRIDGE.MODO_PADRAO;

public class MensagemUsuario : Mensagem
{
    public MensagemUsuario(ICanalEnvio canalEnvio) : base(canalEnvio) { }
    public override void Enviar()
    {
        Console.WriteLine("Mensagem Enviada pelo USUÁRIO");
        _canalEnvio.EnviarMensagem(_assunto, _mensagem);
    }
}