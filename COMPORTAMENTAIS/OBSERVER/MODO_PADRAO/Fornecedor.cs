namespace OBSERVER.MODO_COMUM;


public class Fornecedor : IObserver
{
    private readonly string _nome;
    private readonly string _email;
    private readonly ISubject _subject;

    public Fornecedor(string nome, string email, ISubject subject)
    {
        _nome = nome;
        _email = email;
        _subject = subject;
        _subject.RegisterObserver(this);
    }

    public string GetEmail() => _email;

    public string GetNome() => _nome;

    public void Update(string mensagem) => Email.Enviar(this, mensagem);
}