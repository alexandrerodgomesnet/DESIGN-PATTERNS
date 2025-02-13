namespace ABSTRACT_FACTORY;

public interface ICalculosFactory
{
    public IDesconto CriarDesconto();
    public IJuros CriarJuros();
    public IMulta CriarMulta();
}