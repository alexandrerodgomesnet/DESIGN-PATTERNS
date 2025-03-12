
namespace SINGLETON.MODO_COMUM;

public class MySql : IConexao
{
    private string _host;
    private string _user;
    private string _password;

    public MySql()
    {
        _host = "host";
        _user = "user";
        _password = "password";
    }

    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"A query: {query} foi executada com sucesso");
    }

    public void SetHost(string host) => _host = host;
    public void SetUser(string user) => _user = user;
    public void SetPassword(string password) => _password = password;

    public override string ToString() => 
        $"Host: {_host}; User: {_user}; Password: {_password}";
}
