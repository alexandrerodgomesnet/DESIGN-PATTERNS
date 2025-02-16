﻿/*
    O padrão Builder separa a construção de um objeto complexo de sua representação 
    de modo que o mesmo processo de construção de um objeto possa criar diferentes representações.
*/


// using BUILDER.MODO_COMUM;

// //criação pdf A3
// Console.WriteLine("*********** PDF A3 **********");
// GeradorPdf pdf = new("portrait", "mm", 210, 297, 30, 20, 30, 20, true, 15, true, 15, "#FFFFFF", "UTF-8");
// Console.WriteLine(pdf);

// //criação pdf A4
// Console.WriteLine("*********** PDF A4 **********");
// pdf = new("portrait", "mm", 297, 420, 60, 40, 60, 40, false, 0, false, 0, "#FFFFFF", "UTF-8");
// Console.WriteLine(pdf);

//criação pdf A3
using BUILDER.MODO_PADRAO_1;

Console.WriteLine("*********** PDF A3 **********");
var builderA3 = new BuilderA3(); 
Console.WriteLine(builderA3.GetGeradorPdf());

//criação pdf A4
Console.WriteLine("*********** PDF A4 **********");
var buiderA4 = new BuilderA4();
Console.WriteLine(buiderA4.GetGeradorPdf());