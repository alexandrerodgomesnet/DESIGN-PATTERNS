namespace BUILDER.MODO_PADRAO_1;

public class BuilderA4
{
    private GeradorPdf _geradorPdf;
    public BuilderA4()
    {
        _geradorPdf = new GeradorPdf
        {
            PageOrientation = "Portrait",
            Unit = "mm",
            PageSizeX = 297,
            PageSizeY = 420,
            MarginTop = 60,
            MarginRight = 40,
            MarginBotton = 60,
            MarginLeft = 40,
            HasHeader = false,
            HeaderHeight = 0,
            HasFooter = false,
            FooterHeight = 0,
            PageColor = "#ffffff",
            Encode = "UTF-8"
        };
    }

    public GeradorPdf GetGeradorPdf() => _geradorPdf;
}