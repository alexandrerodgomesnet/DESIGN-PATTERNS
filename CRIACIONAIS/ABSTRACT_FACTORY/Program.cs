/*
    O padrão Abstract Factory fornece uma interface para criar famílias de objetos relacionados 
    ou dependentes sem especificar suas classes concretas.
*/

using ABSTRACT_FACTORY;
using ABSTRACT_FACTORY.BancoBrasil;
using ABSTRACT_FACTORY.Caixa;

var banco = new Banco();
ICalculosFactory factory;

Console.WriteLine();
Console.WriteLine("********** BANCO CAIXA **********");
factory = new BancoCaixaCalculosFactory();
banco.GerarBoleto(100, factory);

Console.WriteLine();
Console.WriteLine("********** BANCO BRASIL **********");
factory = new BancoBrasilCalculosFactory();
banco.GerarBoleto(100, factory);