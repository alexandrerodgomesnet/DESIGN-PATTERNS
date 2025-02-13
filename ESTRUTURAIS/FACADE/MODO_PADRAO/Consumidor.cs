namespace FACADE.MODO_PADRAO;

public class Consumidor
{
    private string _nome;
    private string _cpf;
    private string _email;

    public Consumidor(string nome, string cpf, string email)
    {
        _nome = nome;
        _cpf = cpf;
        _email = email;
    }

    public string GetNome() => _nome;
    public string GetCpf() => _cpf;
    public string GetEmail() => _email;

}