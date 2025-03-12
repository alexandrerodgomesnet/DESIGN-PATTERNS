
namespace SINGLETON.MODO_PADRAO;

public class MySql : IConexao
{
    private static MySql? _instance = null;
    private string _host;
    private string _user;
    private string _password;

    private MySql()
    {
        _host = "host";
        _user = "user";
        _password = "password";
    }

    public static MySql GetInstance() => _instance ??= new MySql();

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
