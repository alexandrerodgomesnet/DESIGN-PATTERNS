/*
    O Padrão Chain of Responsibility evita o acoplamento 
    do remetente de uma solicitação ao seu receptor, 
    dando a mais de um objeto a oportunidade de tratar a solicitação. 
    Ele encadeia os objetos receptores, passando a solicitação 
    ao longo da cadeia até que um objeto a trate.
*/

using CHAIN_OF_RESPONSIBILITY.MODO_PADRAO;

var pedido = new Pedido();
var calculadora = new CalculadoraPontos();

pedido.SetValor(21);

Console.WriteLine($"Dia 15: {calculadora.CalcularPontos(pedido, 15)} Pontos");
Console.WriteLine($"Dia 16: {calculadora.CalcularPontos(pedido, 16)} Pontos");

Console.WriteLine("----------------------------");

pedido.SetValor(100);

Console.WriteLine($"Dia 15: {calculadora.CalcularPontos(pedido, 15)} Pontos");
Console.WriteLine($"Dia 16: {calculadora.CalcularPontos(pedido, 16)} Pontos");