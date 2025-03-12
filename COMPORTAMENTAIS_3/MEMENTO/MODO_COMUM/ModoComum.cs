namespace MEMENTO.MODO_COMUM;

public class ModoComum
{
    public static void Run()
    {
        var textBox = new TextBox(20, 100);

        textBox.SetText("Criando um TextBox");
        textBox.SetFontWeight("bold");
        textBox.SetFontFamily("Cursive");
        textBox.SetFontSize(25);
        textBox.Imprimir();

        textBox.SetText("Criando outro TextBox");
        textBox.SetFontWeight("normal");
        textBox.SetFontFamily("monospace");
        textBox.SetFontSize(15);
        textBox.SetPosition(40, 110);
        textBox.Imprimir();

        textBox.SetText("Criando mais um TextBox");
        textBox.SetFontWeight("normal");
        textBox.SetFontFamily("fantasy");
        textBox.SetFontSize(12);
        textBox.SetPosition(60, 120);
        textBox.Imprimir();
    }
}