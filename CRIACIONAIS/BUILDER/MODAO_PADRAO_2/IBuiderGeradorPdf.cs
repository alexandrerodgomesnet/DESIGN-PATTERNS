using BUILDER.MODO_PADRAO_2;

namespace BUILDER.MODAO_PADRAO_2;

public interface IBuiderGeradorPdf
{
    GeradorPdf GetGeradorPdf();
    void SetPageConfigurartion();
    void SetMargin();
    void SetHeader();
    void SetFooter();
}