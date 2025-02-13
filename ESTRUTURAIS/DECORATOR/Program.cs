/*
    O Padrão Decorator anexa responsabilidades adicionais a um objeto dinamicamente. 
    Os Decorators fornecem uma alternativa flexível ao uso de 
    subclasses para extensão de funcionalidades.
*/


using DECORATOR.MODO_PADRAO;

var pizzaQueijo = new PizzaQueijo();

var descricao = pizzaQueijo.GetDescricao();
var preco = pizzaQueijo.GetPreco();

Console.WriteLine(descricao);
Console.WriteLine($"R$ {preco}");

var pizzaQueijoBordaRequeijao = new BordaRequeijao(pizzaQueijo);

descricao = pizzaQueijoBordaRequeijao.GetDescricao();
preco = pizzaQueijoBordaRequeijao.GetPreco();

Console.WriteLine(descricao);
Console.WriteLine($"R$ {preco}");

var pizzaQueijoMassaIntegral = new MassaIntegral(pizzaQueijoBordaRequeijao);

descricao = pizzaQueijoMassaIntegral.GetDescricao();
preco = pizzaQueijoMassaIntegral.GetPreco();

Console.WriteLine(descricao);
Console.WriteLine($"R$ {preco}");