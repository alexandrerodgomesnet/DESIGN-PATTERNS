using BUILDER.MODO_PADRAO_3;

namespace BUILDER.MODAO_PADRAO_3;

public interface IBuiderGeradorPdf
{
    GeradorPdf GetGeradorPdf();
    void SetPageConfigurartion();
    void SetMargin();
    void SetHeader();
    void SetFooter();
}