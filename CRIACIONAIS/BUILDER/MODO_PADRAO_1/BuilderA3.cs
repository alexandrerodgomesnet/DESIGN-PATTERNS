namespace BUILDER.MODO_PADRAO_1;

public class BuilderA3
{
    private GeradorPdf _geradorPdf;
    public BuilderA3()
    {
        _geradorPdf = new GeradorPdf
        {
            PageOrientation = "Portrait",
            Unit = "mm",
            PageSizeX = 210,
            PageSizeY = 297,
            MarginTop = 30,
            MarginRight = 20,
            MarginBotton = 30,
            MarginLeft = 20,
            HasHeader = true,
            HeaderHeight = 15,
            HasFooter = true,
            FooterHeight = 15,
            PageColor = "#ffffff",
            Encode = "UTF-8"
        };
    }
    public GeradorPdf GetGeradorPdf() => _geradorPdf;
}