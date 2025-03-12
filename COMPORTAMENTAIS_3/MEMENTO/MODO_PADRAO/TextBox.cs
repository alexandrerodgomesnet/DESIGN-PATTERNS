namespace MEMENTO.MODO_PADRAO;

public class TextBox : IOriginador
{
    private int _posicaoX;
    private int _posicaoY;
    private string _text;
    private string _fontFamily;
    private int _fontSize;
    private string _textAlign;
    private string _fontWeight;

    public TextBox(int posicaoX, int posicaoY)
    {
        _posicaoX = posicaoX;
        _posicaoY = posicaoY;
        _text = string.Empty;
        _fontFamily = "Arial";
        _fontSize = 14;
        _textAlign = "Left";
        _fontWeight = "Normal";
    }

    public void Imprimir()
    {
        Console.WriteLine($"<div style='margin-left: {_posicaoX}px; margin-top: {_posicaoY}px;'");
        Console.WriteLine($"<span style='font-size: {_fontSize}px; font-family: {_fontFamily}; font-weight: {_fontWeight};'");
        Console.WriteLine(_text);
        Console.WriteLine("</span></div>");
    }

    public void SetPosition(int posicaoX, int posicaoY)
    {
        _posicaoX = posicaoX;
        _posicaoY = posicaoY;
    }

    public void SetText(string text) => _text = text;
    public void SetFontFamily(string fontFamily) => _fontFamily = fontFamily;
    public void SetFontSize(int fontSize) => _fontSize = fontSize;
    public void SetTextAlign(string textAlign) => _textAlign = textAlign;
    public void SetFontWeight(string fontWeight) => _fontWeight = fontWeight;

    public IMemento Salvar() => new TextBoxMemento(this, _posicaoX, _posicaoY,
        _text, _fontFamily, _fontSize, _textAlign, _fontWeight);
}