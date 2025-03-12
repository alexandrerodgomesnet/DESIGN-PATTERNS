namespace MEMENTO.MODO_PADRAO;

public class ModoPadrao
{
    public static void Run()
    {
        var textBox = new TextBox(20, 100);
        var historico = new Historico();

        textBox.SetText("Criando um TextBox");
        textBox.SetFontWeight("bold");
        textBox.SetFontFamily("Cursive");
        textBox.SetFontSize(25);
        historico.CriarCheckPoint(textBox);

        textBox.SetText("Criando outro TextBox");
        textBox.SetFontWeight("normal");
        textBox.SetFontFamily("monospace");
        textBox.SetFontSize(15);
        textBox.SetPosition(40, 110);
        historico.CriarCheckPoint(textBox);

        textBox.SetText("Criando mais um TextBox");
        textBox.SetFontWeight("normal");
        textBox.SetFontFamily("fantasy");
        textBox.SetFontSize(12);
        textBox.SetPosition(60, 120);
        historico.CriarCheckPoint(textBox);

        historico.Imprimir(textBox);
        historico.Desfazer();
        historico.Desfazer();
        historico.Imprimir(textBox);
    }
}