namespace ABSTRACT_FACTORY.Caixa;

public class BancoCaixaCalculosFactory : ICalculosFactory
{
    public IDesconto CriarDesconto() => new CaixaDesconto();
    public IJuros CriarJuros() => new CaixaJuros();
    public IMulta CriarMulta() => new CaixaMulta();
}