namespace DECORATOR.MODO_PADRAO;

public abstract class Pizza
{
    protected string _descricao = "Descricao não definida.";
    protected decimal _preco;

    public abstract string GetDescricao();
    public abstract decimal GetPreco();
}