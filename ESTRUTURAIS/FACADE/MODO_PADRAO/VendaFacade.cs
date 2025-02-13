namespace FACADE.MODO_PADRAO;

public class VendaFacade
{
    private Pedido _pedido;
    private Pagamento? _pagamento;
    private EmailPedido _email;

    public VendaFacade(Consumidor consumidor)
    {
        _pedido = new Pedido(consumidor);
        _email = new EmailPedido(_pedido);
    }

    public void AddProduto(Produto produto) => _pedido.AddProduto(produto);
    public void PedidoCredito()
    {
        _pagamento = new PagamentoCredito(_pedido);
        if(_pagamento.RealizarPagamento())
            _email.EnviarEmail("Pagamento via Crédito realizado com sucesso.");
        else
            _email.EnviarEmail("Falha ao realizar pagamento via Crédito.");
    }

    public void PedidoBoleto()
    {
        _pagamento = new PagamentoBoleto(_pedido);
        if(_pagamento.RealizarPagamento())
            _email.EnviarEmail("Pagamento via boleto realizado com sucesso.");
        else
            _email.EnviarEmail("Falha ao realizar pagamento via boleto.");
    }
}