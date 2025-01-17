/*
    O padrão Template Method define o esqueleto de um algoritmo dentro de um método, 
    transferindo alguns de seus passos para subclasses.
    O Template Method permite que as subclasses redefinam certos passos de um algoritmo
    sem alterar a estrutura do mesmo.
*/
using TEMPLATE_METHOD.MODO_COMUM;

var valor = 1000;
 Gateway gateway = new();

 Console.WriteLine("Crédito");
 var pagamentoCredito = new PagamentoCredito(valor, gateway);
 pagamentoCredito.RealizarCobranca();

Console.WriteLine("Dédito");
var pagamentoDebito = new PagamentoDebito(valor, gateway);
pagamentoDebito.RealizarCobranca();

Console.WriteLine("Dinheiro");
var pagamentoDinheiro = new PagamentoDinheiro(valor, gateway);
pagamentoDinheiro.RealizarCobranca();
