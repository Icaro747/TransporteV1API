namespace TransporteV1API.Data.Dtos;

public class CreateDocumentoFun
{
    public string Tipo { get; set; }
    public DateTime Validade { get; set; }
    public string Documento { get; set; }
    public string Descritivo { get; set; }
    public Guid IdFuncionario { get; set; }
}
