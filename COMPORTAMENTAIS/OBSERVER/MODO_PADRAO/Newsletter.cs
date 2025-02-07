namespace OBSERVER.MODO_PADRAO;

public class Newsletter : ISubject
{
    private readonly List<IObserver> _observers = [];
    private readonly List<string> _mensagens = [];

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        for (int key = 0; key < _observers.Count; ++key)
        {
            if(_observers[key] == observer)
                _observers.Remove(observer);
        }
    }

    public void NotifyObserver()
    {
        foreach (var item in _observers)
        {
            item.Update(_mensagens.LastOrDefault() ?? string.Empty);
        }
    }

    public void AddMensagem(string mensagem)
    {
        _mensagens.Add(mensagem);
        NotifyObserver();
    }
}
