/*
    O padrão de projeto State permite que um objeto altere o seu comportamento 
    quando o seu estado interno muda. 
    O objeto parecerá ter mudado de classe.
*/


// using STATE.MODO_COMUM;

// var pedido = new Pedido();
// //pedido.DespacharPedido();

// pedido.SucessoAoPagar();
// //pedido.CancelarPedido();
// pedido.DespacharPedido();

using STATE.MODO_PADRAO;

var pedido = new Pedido();
pedido.RealizarPagamento();
pedido.RealizarPagamento();