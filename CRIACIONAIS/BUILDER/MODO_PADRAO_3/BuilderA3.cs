using BUILDER.MODAO_PADRAO_3;

namespace BUILDER.MODO_PADRAO_3;

public class BuilderA3 : IBuiderGeradorPdf
{
    private GeradorPdf _geradorPdf;
    public BuilderA3()
    {
        _geradorPdf = new GeradorPdf();
    }
    public GeradorPdf GetGeradorPdf() => _geradorPdf;

    public void SetPageConfigurartion()
    {
        _geradorPdf.PageOrientation = "Portrait";
        _geradorPdf.Unit = "mm";
        _geradorPdf.PageSizeX = 210;
        _geradorPdf.PageSizeY = 297;
        _geradorPdf.PageColor = "#ffffff";
        _geradorPdf.Encode = "UTF-8";
    }

    public void SetFooter()
    {
        _geradorPdf.HasFooter = true;
        _geradorPdf.FooterHeight = 15;
    }

    public void SetHeader()
    {
        _geradorPdf.HasHeader = true;
        _geradorPdf.HeaderHeight = 15;
    }

    public void SetMargin()
    {
        _geradorPdf.MarginTop = 30;
        _geradorPdf.MarginRight = 20;
        _geradorPdf.MarginBotton = 30;
        _geradorPdf.MarginLeft = 20;
    }
}