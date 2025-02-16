using System.Text;

namespace BUILDER.MODO_PADRAO_1;

public class GeradorPdf
{
    public string PageOrientation { get; set; } = "portrait";
    public string Unit { get; set; } = "mm";
    public int PageSizeX { get; set; } = 210;
    public int PageSizeY { get; set; } = 297;
    public int MarginTop { get; set; } = 30;
    public int MarginRight { get; set; } = 20;
    public int MarginBotton { get; set; } = 30;
    public int MarginLeft { get; set; } = 20;
    public bool HasHeader { get; set; } = false;
    public int HeaderHeight { get; set; } = 0;
    public bool HasFooter { get; set; } = false;
    public int FooterHeight { get; set; } = 0;
    public string PageColor { get; set; } = "#ffffff";
    public string Encode { get; set; } = "UTF-8";    

    public override string ToString()
    {
        var resultado = new StringBuilder();

        resultado.AppendLine($"PageOrientation: {PageOrientation}");
        resultado.AppendLine($"Unit: {Unit}");
        resultado.AppendLine($"PageSizeX: {PageSizeX} mm");
        resultado.AppendLine($"PageSizeY: {PageSizeY} mm");
        resultado.AppendLine($"MarginTop: {MarginTop} mm");
        resultado.AppendLine($"MarginRight: {MarginRight} mm");
        resultado.AppendLine($"MarginBotton: {MarginBotton} mm");
        resultado.AppendLine($"MarginLeft: {MarginLeft} mm");
        resultado.AppendLine(HasHeader ? "HasHeader: Sim" : "HasHeader: Não");
        resultado.AppendLine($"HeaderHeight: {HeaderHeight} mm");
        resultado.AppendLine(HasFooter ? "HasFooter: Sim" : "HasFooter: Não");
        resultado.AppendLine($"FooterHeight: {FooterHeight} mm");
        resultado.AppendLine($"PageColor: {PageColor}");
        resultado.AppendLine($"Encode: {Encode}");

        return resultado.ToString();
    }
}