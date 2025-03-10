namespace PROXY.MODO_PADRAO;

public class Usuario
{
    private string _nome;
    private string _cpf;
    private int _idade;
    private IReceitaFederal _pessoaFisica;

    public Usuario(string nome, string cpf, int idade)
    {
        _nome = nome;
        _cpf = cpf;
        _idade = idade;
        _pessoaFisica = new PessoaFisicaReceitaFederalProxy(_cpf);        
    }

    public bool ValidarNome() => _nome == _pessoaFisica.GetNome();
    public bool VerificarCpfAtivo() => _pessoaFisica.CpfAtivo();
    public bool VerificarMaiorIdade() => _idade >= 18 
        && _idade == _pessoaFisica.GetIdade();

    public string GetNome() => _nome;
    public string GetCpf() => _cpf;
    public int GetIdade() => _idade;
}