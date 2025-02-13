﻿/*
    O Padrão Factory Method define uma interface para criar um objeto, 
    mas permite que a subclasses possam decidir qual classe instanciar, 
    possibilitando que uma classe seja capaz de prorrogar a instanciação de uma classe para subclasses.
*/

// using FACTORY_METHOD.MODO_COMUM;

// var bancoCaixa = new BancoCaixa();
// bancoCaixa.GerarBoleto(10, 100);
// bancoCaixa.GerarBoleto(30, 100);
// bancoCaixa.GerarBoleto(60, 100);

using FACTORY_METHOD.MODO_PADRAO_1;

var factory = new BoletoSimpleFactory();

var bancoCaixa = new BancoCaixa(factory);
bancoCaixa.GerarBoleto(10, 100);
bancoCaixa.GerarBoleto(30, 100);
bancoCaixa.GerarBoleto(60, 100);