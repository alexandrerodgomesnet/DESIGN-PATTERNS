/*
    ​O Padrão Bridge desacopla uma abstração de sua implementação, ou seja, 
    permite dividir uma classe grande ou um conjunto de classes diretamente 
    ligadas em duas hierarquias separadas, deste modo as duas hierarquias 
    podem variar de forma independente.
*/

// using BRIDGE.MODO_COMUM;

// var mensagemAdminEmail = new MensagemAdminEmail();
// mensagemAdminEmail.SetAssunto("Primeira mensagem");
// mensagemAdminEmail.SetMensagem("Olá Usuário...");
// mensagemAdminEmail.Enviar();

// var mensagemUsuarioEmail = new MensagemUsuarioEmail();
// mensagemUsuarioEmail.SetAssunto("Primeira mensagem");
// mensagemUsuarioEmail.SetMensagem("Olá Administrador...");
// mensagemUsuarioEmail.Enviar();

// var mensagemAdminSMS = new MensagemAdminSMS();
// mensagemAdminSMS.SetAssunto("Primeira mensagem");
// mensagemAdminSMS.SetMensagem("Olá Usuário...");
// mensagemAdminSMS.Enviar();

// var mensagemUsuarioSMS = new MensagemUsuarioSMS();
// mensagemUsuarioSMS.SetAssunto("Primeira mensagem");
// mensagemUsuarioSMS.SetMensagem("Olá Administrador...");
// mensagemUsuarioSMS.Enviar();

using BRIDGE.MODO_PADRAO;

var email = new Email();
var sms = new Sms();

var mensagemAdmin = new MensagemAdmin(email);
mensagemAdmin.SetAssunto("Segunda Mensagem");
mensagemAdmin.SetMensagem("Olá Usuário...");
mensagemAdmin.Enviar();

mensagemAdmin = new MensagemAdmin(sms);
mensagemAdmin.SetAssunto("Segunda Mensagem");
mensagemAdmin.SetMensagem("Olá Usuário...");
mensagemAdmin.Enviar();

var mensagemUsuario = new MensagemUsuario(email);
mensagemUsuario.SetAssunto("Segunda Mensagem");
mensagemUsuario.SetMensagem("Olá Administrador...");
mensagemUsuario.Enviar();

mensagemUsuario = new MensagemUsuario(sms);
mensagemUsuario.SetAssunto("Segunda Mensagem");
mensagemUsuario.SetMensagem("Olá Administrador...");
mensagemUsuario.Enviar();