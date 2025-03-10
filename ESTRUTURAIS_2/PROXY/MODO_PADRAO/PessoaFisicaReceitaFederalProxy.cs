namespace PROXY.MODO_PADRAO;

public class PessoaFisicaReceitaFederalProxy : IReceitaFederal
{
    private string _cpf;
    private IReceitaFederal? _pessoaFisica;
    public PessoaFisicaReceitaFederalProxy(string cpf)
    {
        _cpf = cpf;
    }
    private void CriarPessoaFisica()
    {
        _pessoaFisica ??= new PessoaFisicaReceitaFederal(_cpf);
    }
    public bool CpfAtivo()
    {
        CriarPessoaFisica();
        return _pessoaFisica.CpfAtivo();
    }

    public int GetIdade()
    {
        CriarPessoaFisica();
        return _pessoaFisica.GetIdade();
    }

    public string GetNome()
    {
        CriarPessoaFisica();
        return _pessoaFisica.GetNome();
    }
}