/*
    O Observer é um padrão de projeto de software que define 
    uma dependência um-para-muitos entre objetos, 
    de modo que quando um objeto muda seu estado, 
    todos seus dependentes são notificados e atualizados automaticamente.
*/

using OBSERVER.MODO_PADRAO;

var newsletter = new Newsletter();

var funcionarioAbc = new Funcionario("ABC", "abc@email.com", newsletter);
var funcionarioXyz = new Funcionario("XYZ", "xyz@email.com", newsletter);

var Cliente = new Cliente("Cliente", "cliente@email", newsletter);
var parceiro = new Parceiro("Parceiro", "parceiro@email.com", newsletter);
var fornecedor = new Fornecedor("Fornecedor", "fornecedor@email.com", newsletter);

newsletter.AddMensagem("Mensagem Teste");
Console.WriteLine("######################");

newsletter.RemoveObserver(funcionarioXyz);

newsletter.AddMensagem("Mensagem Teste 2");
Console.WriteLine("######################");