namespace COMMAND.MODO_PADRAO;

public interface ICommand
{
    void Executar();
    void Desfazer();
}