namespace VISITOR.MODO_PADRAO;

public class Supermercado : IElemento
{
    private string _nome;
    private List<Departamento> _departamentos;

    public Supermercado(string nome)
    {
        _nome = nome;
        _departamentos = [];
    }

    public void AdicionarDepartamento(Departamento departamento) => _departamentos.Add(departamento);
    public string GetNome() => _nome;
    public List<Departamento> GetDepartamentos() => _departamentos;

    public decimal Aceitar(IVisitor visitor) => visitor.VisitorSupermercado(this);
}