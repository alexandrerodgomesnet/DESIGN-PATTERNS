namespace OBSERVER.MODO_PADRAO;

public interface IObserver
{
    void Update(string mensagem);
    string GetNome();
    string GetEmail();
}