namespace BRIDGE.MODO_PADRAO;

public class MensagemAdmin : Mensagem
{
    public MensagemAdmin(ICanalEnvio canalEnvio) : base(canalEnvio) { }

    public override void Enviar()
    {
        Console.WriteLine("Mensagem Enviada pelo ADMINISTRADOR");
        _canalEnvio.EnviarMensagem(_assunto, _mensagem);
    }
}