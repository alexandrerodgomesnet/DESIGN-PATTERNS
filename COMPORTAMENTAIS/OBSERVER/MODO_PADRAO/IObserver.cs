namespace OBSERVER.MODO_COMUM;

public interface IObserver
{
    void Update(string mensagem);
    string GetNome();
    string GetEmail();
}