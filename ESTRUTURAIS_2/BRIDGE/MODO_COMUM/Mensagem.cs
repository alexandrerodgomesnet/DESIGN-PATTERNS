namespace BRIDGE.MODO_COMUM;

public abstract class Mensagem
{
    protected string _assunto = string.Empty;
    protected string _mensagem = string.Empty;

    public void SetAssunto(string assunto) => _assunto = assunto;
    public void SetMensagem(string mensagem) => _mensagem = mensagem;
    public abstract void Enviar();
}