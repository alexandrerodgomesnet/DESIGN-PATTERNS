/*
    O padrão de projeto Command encapsula uma solicitação como um objeto, 
    isso lhe permite parametrizar clientes com diferentes solicitações, 
    enfileirar ou registrar (log) solicitações e suportar solicitações que podem ser desfeitas.
*/

using COMMAND.MODO_PADRAO;

var lampadaSala = new Lampada(identificacao: "Lampada da Sala", estado: false);
// lampadaSala.Ligar();
// lampadaSala.ImprimeObjeto();
// lampadaSala.Desligar();
// lampadaSala.ImprimeObjeto();

var lampadaQuarto = new Lampada(identificacao: "Lampada do Quarto", estado: false);
// lampadaQuarto.Ligar();
// lampadaQuarto.ImprimeObjeto();
// lampadaQuarto.Desligar();
// lampadaQuarto.ImprimeObjeto();

var arCondicionado = new ArCondicionado(identificacao: "Ar Condicionado", estado: false, temperatura: 26);
// arCondicionado.Ligar();
// arCondicionado.ImprimeObjeto();
// arCondicionado.SetTempeartura(25);
// arCondicionado.ImprimeObjeto();
// arCondicionado.Desligar();
// arCondicionado.ImprimeObjeto();

var aplicativo = new Aplicativo();

var ligarLampadaSala = new LigarLampada(lampadaSala);
var desligarLampadaSala = new DesligarLampada(lampadaSala);

var ligarLampadaQuarto = new LigarLampada(lampadaQuarto);
var desligarLampadaQuarto = new DesligarLampada(lampadaQuarto);

var ligarAr = new LigarArCondicionado(arCondicionado);
var desligarAr = new DesligarArCondicionado(arCondicionado);
var mudarTempAr = new MudarTemperaturaArCondicionado(arCondicionado);

var idLigarLampadaSala = aplicativo.SetCommando(ligarLampadaSala);
var idDesligarLampadaSala = aplicativo.SetCommando(desligarLampadaSala);

var idLigarLampadaQuarto = aplicativo.SetCommando(ligarLampadaQuarto);
var idDesligarLampadaQuarto = aplicativo.SetCommando(desligarLampadaQuarto);

var idLigarAr = aplicativo.SetCommando(ligarAr);
var idDesligarAr = aplicativo.SetCommando(desligarAr);
var idMudarTemp = aplicativo.SetCommando(mudarTempAr);

aplicativo.AoPrecionarBotao(idLigarLampadaSala);
aplicativo.AoPrecionarBotao(idDesligarLampadaSala);

aplicativo.AoPrecionarBotao(idLigarLampadaQuarto);
aplicativo.AoPrecionarBotao(idDesligarLampadaQuarto);

aplicativo.AoPrecionarBotao(idLigarAr);
var commandApp = (MudarTemperaturaArCondicionado)aplicativo.GetComando(idMudarTemp);
commandApp.SetTempeartura(25);
aplicativo.AoPrecionarBotao(idMudarTemp);
aplicativo.AoPrecionarBotao(idDesligarAr);


Console.WriteLine("************* Desfazer Comandos *************");
aplicativo.DuploCliqueBotao(idLigarAr);
aplicativo.DuploCliqueBotao(idLigarLampadaQuarto);
aplicativo.DuploCliqueBotao(idLigarLampadaSala);

