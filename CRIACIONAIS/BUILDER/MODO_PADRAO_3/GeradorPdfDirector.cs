using BUILDER.MODAO_PADRAO_3;

namespace BUILDER.MODO_PADRAO_3;

public class GeradorPdfDirector
{
    private IBuiderGeradorPdf _buiderGedorPdf;

    public GeradorPdfDirector(IBuiderGeradorPdf buiderGedorPdf)
    {
        _buiderGedorPdf = buiderGedorPdf;
    }

    public void SetBuiderGeradorPdf(IBuiderGeradorPdf buiderGedorPdf)
    {
        _buiderGedorPdf = buiderGedorPdf;
    }

    public void CriarGeradorPdf()
    {
        _buiderGedorPdf.SetPageConfigurartion();
        _buiderGedorPdf.SetMargin();
        _buiderGedorPdf.SetHeader();
        _buiderGedorPdf.SetFooter();
    }

       public void CriarGeradorPdfNoHeader()
    {
        _buiderGedorPdf.SetPageConfigurartion();
        _buiderGedorPdf.SetMargin();
        _buiderGedorPdf.SetFooter();
    }

       public void CriarGeradorPdfNoHeaderNoFooter()
    {
        _buiderGedorPdf.SetPageConfigurartion();
        _buiderGedorPdf.SetMargin();
    }
}