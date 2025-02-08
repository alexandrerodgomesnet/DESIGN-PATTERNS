/*
    O padrão Adapter converte a interface de uma classe para 
    outra interface que o cliente esperar encontrar. 
    O Adaptador permite que classes com interfaces incompatíveis trabalhem juntas.
*/


// using ADAPTER.MODO_COMUM;
// using ADAPTER.MODO_COMUM.TERCEIROS;

// var pagFacil = new PagFacil();

// var cobranca = new Cobranca(pagFacil);
// cobranca.SetValor(100);
// cobranca.SetParcelas(3);
// cobranca.SetNumeroCartao("12345678900");
// cobranca.SetCVV("123");

// if(cobranca.RealizarPagamento())
//     Console.WriteLine("Sucesso");
// else
//     Console.WriteLine("Falha");

using ADAPTER.MODO_PADRAO;
using ADAPTER.MODO_PADRAO.TERCEIROS;

var pagFacil = new PagFacilAdapter();
var topPagamentos =  new TopPagamentos();
var topPagamentosAdapter =  new TopPagamentosAdapter(topPagamentos);

var cobranca = new Cobranca(topPagamentosAdapter);
cobranca.SetValor(100);
cobranca.SetParcelas(3);
cobranca.SetNumeroCartao("12345678900");
cobranca.SetCVV("123");

if(cobranca.RealizarPagamento())
    Console.WriteLine("Sucesso");
else
    Console.WriteLine("Falha");