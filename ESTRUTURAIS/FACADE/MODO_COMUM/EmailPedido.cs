namespace FACADE.MODO_COMUM;

public class EmailPedido
{
    private readonly Pedido _pedido;

    public EmailPedido(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void EnviarEmail(string mensagem)
    {
        Console.WriteLine($"Email enviado para {_pedido.GetConsumidor().GetEmail()}");
        Console.WriteLine($"Mensagem: {mensagem}");
    }
}