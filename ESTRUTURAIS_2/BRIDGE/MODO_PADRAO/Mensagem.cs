namespace BRIDGE.MODO_PADRAO;

public abstract class Mensagem
{
    protected string _assunto = string.Empty;
    protected string _mensagem = string.Empty;
    protected ICanalEnvio _canalEnvio;

    protected Mensagem(ICanalEnvio canalEnvio)
    {
        _canalEnvio = canalEnvio;
    }

    public void SetAssunto(string assunto) => _assunto = assunto;
    public void SetMensagem(string mensagem) => _mensagem = mensagem;
    public abstract void Enviar();
}