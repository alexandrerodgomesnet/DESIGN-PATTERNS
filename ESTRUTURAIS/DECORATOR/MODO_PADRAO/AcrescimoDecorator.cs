namespace DECORATOR.MODO_PADRAO;

public abstract class AcrescimoDecorator(Pizza pizza) : Pizza
{
    protected Pizza _pizza = pizza;
}