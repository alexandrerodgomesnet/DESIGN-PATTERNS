namespace MEMENTO.MODO_PADRAO;

public class TextBoxMemento : IMemento
{
    private TextBox _textBox;
    private int _posicaoX;
    private int _posicaoY;
    private string _text;
    private string _fontFamily;
    private int _fontSize;
    private string _textAlign;
    private string _fontWeight;

    public TextBoxMemento(TextBox textBox, int posicaoX, int posicaoY,
        string text, string fontFamily, int fontSize, string textAlign, string fontWeight)
    {
        _textBox = textBox;
        _posicaoX = posicaoX;
        _posicaoY = posicaoY;
        _text = text;
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        _textAlign = textAlign;
        _fontWeight = fontWeight;
    }

    public void Restaurar()
    {
        _textBox.SetPosition(_posicaoX, _posicaoY);
        _textBox.SetText(_text);
        _textBox.SetFontFamily(_fontFamily);
        _textBox.SetFontSize(_fontSize);
        _textBox.SetTextAlign(_textAlign);
        _textBox.SetFontWeight(_fontWeight);
    }
}
