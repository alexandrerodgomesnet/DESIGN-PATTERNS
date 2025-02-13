namespace ABSTRACT_FACTORY.BancoBrasil;

public class BancoBrasilCalculosFactory : ICalculosFactory
{
    public IDesconto CriarDesconto() => new BancoBrasilDesconto();
    public IJuros CriarJuros() => new BancoBrasilJuros();
    public IMulta CriarMulta() => new BancoBrasilMulta();
}