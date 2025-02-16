using BUILDER.MODAO_PADRAO_3;

namespace BUILDER.MODO_PADRAO_3;

public class BuilderA4 : IBuiderGeradorPdf
{
    private GeradorPdf _geradorPdf;
    public BuilderA4()
    {
        _geradorPdf = new GeradorPdf();
    }

    public GeradorPdf GetGeradorPdf() => _geradorPdf;

    public void SetPageConfigurartion()
    {
        _geradorPdf.PageOrientation = "Portrait";
        _geradorPdf.Unit = "mm";
        _geradorPdf.PageSizeX = 297;
        _geradorPdf.PageSizeY = 420;
        _geradorPdf.PageColor = "#ffffff";
        _geradorPdf.Encode = "UTF-8";
    }

    public void SetFooter()
    {
        _geradorPdf.HasFooter = false;
        _geradorPdf.FooterHeight = 0;
    }

    public void SetHeader()
    {
        _geradorPdf.HasHeader = false;
        _geradorPdf.HeaderHeight = 0;
    }

    public void SetMargin()
    {
        _geradorPdf.MarginTop = 60;
        _geradorPdf.MarginRight = 40;
        _geradorPdf.MarginBotton = 60;
        _geradorPdf.MarginLeft = 40;
    }
}