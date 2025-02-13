/*
    O padrão Facade fornece uma interface unificada para um conjunto de interfaces em um subsistema. 
    O Facade define uma interface de nível mais alto que facilita a utilização do subsistema.
*/

// using FACADE.MODO_COMUM;

// var consumidor = new Consumidor("Alexandre", "123456789-00", "alexandre@email.com");

// var produto1 = new Produto("Tenis", "Tenis de corrida", 100M);
// var produto2 = new Produto("Camisa dry fit", "Camisa leve que evita suor", 75M);
// var produto3 = new Produto("Oculos de sol", "Oculos para uso em atividade com dias ensoladados", 25M);

// var pedido = new Pedido(consumidor);
// pedido.AddProduto(produto1);
// pedido.AddProduto(produto2);
// pedido.AddProduto(produto3);

// var pagamento = new PagamentoBoleto(pedido);
// var email = new EmailPedido(pedido);

// if(pagamento.RealizarPagamento())
//     email.EnviarEmail("Pagamento realizado com sucesso via boleto.");
// else
//     email.EnviarEmail("Falha no pagamento do boleto");

using FACADE.MODO_PADRAO;

var consumidor = new Consumidor("Alexandre", "123456789-00", "alexandre@email.com");

var produto1 = new Produto("Tenis", "Tenis de corrida", 100M);
var produto2 = new Produto("Camisa dry fit", "Camisa leve que evita suor", 75M);
var produto3 = new Produto("Oculos de sol", "Oculos para uso em atividade com dias ensoladados", 25M);

var facade = new VendaFacade(consumidor);
facade.AddProduto(produto1);
facade.AddProduto(produto2);
facade.AddProduto(produto3);

facade.PedidoBoleto();