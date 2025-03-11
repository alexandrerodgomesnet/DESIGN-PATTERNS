namespace COMPOSITE.MODO_PADRAO;

public class GerenciadorArquivos
{
    private Componente _raiz;
    public GerenciadorArquivos(Componente raiz)
    {
        _raiz = raiz;
    }

    public void ExibirTodos() => _raiz.Exibir();
}