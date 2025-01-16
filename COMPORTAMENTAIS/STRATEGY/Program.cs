

using STRATEGY.MODO_COMUM;

var pedido = new Pedido();
pedido.SetValor(100);


Console.WriteLine($"Frete Comum: {pedido.CalcularFreteComum()}");
Console.WriteLine($"Frete Expresso: {pedido.CalcularFreteExpresso()}");