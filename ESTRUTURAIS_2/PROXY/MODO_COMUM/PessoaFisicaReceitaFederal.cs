namespace PROXY.MODO_COMUM;

public class PessoaFisicaReceitaFederal
{
    private string _nome;
    private string _cpf;
    private int _idade;
    private bool _cpfAtivo;

    public PessoaFisicaReceitaFederal(string cpf)
    {
        _cpf = cpf;
        _nome = "João da Silva";
        _idade = 25;
        _cpfAtivo = true;

        Thread.Sleep(5000);
        Console.WriteLine("PessoaFisicaReceitaFederal criado com sucesso");
    }

    public string GetNome()
    {
        Thread.Sleep(2000);
        return _nome;
    }

    public int GetIdade()
    {
        Thread.Sleep(2000);
        return _idade;
    }

    public bool CpfAtivo()
    {
        Thread.Sleep(3000);
        return _cpfAtivo;
    }
}