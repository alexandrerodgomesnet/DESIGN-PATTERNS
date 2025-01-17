/*
    O padrão de projeto Strategy define uma família de algoritmos, 
    encapsula cada um deles e os torna intercambiáveis. 
    O Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam.
*/

using STRATEGY.MODO_COMUM;
using STRATEGY.MODO_PADRAO;

// var pedido = new Pedido();
// pedido.SetValor(100);


// Console.WriteLine($"Frete Comum: {pedido.CalcularFreteComum()}");
// Console.WriteLine($"Frete Expresso: {pedido.CalcularFreteExpresso()}");  

//USANDO MODO PADRAO

// Pedido pedido = new PedidoEletronicos();
// pedido.SetValor(100);

// Console.WriteLine("Pedido Eletrônicos");
// Console.WriteLine($"Frete Comum: {pedido.CalcularFreteComum()}");
// Console.WriteLine($"Frete Expresso: {pedido.CalcularFreteExpresso()}"); 

// Console.WriteLine("*************************************************");
// pedido = new PedidoMoveis();
// pedido.SetValor(100);

// Console.WriteLine("Pedido Móveis");
// Console.WriteLine($"Frete Comum: {pedido.CalcularFreteComum()}");

// try
// {
//     Console.WriteLine($"Frete Expresso: {pedido.CalcularFreteExpresso()}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message.ToString());
// }

Pedido pedido = new PedidoEletronicos();
pedido.SetValor(100);

IFrete freteComum = new FreteComum();
pedido.SetTipoFrete(freteComum);
Console.WriteLine($"Frete Comum: {pedido.CalcularFrete()}");

IFrete freteExpresso = new FreteExpresso();
pedido.SetTipoFrete(freteExpresso);
Console.WriteLine($"Frete Expresso: {pedido.CalcularFrete()}");
