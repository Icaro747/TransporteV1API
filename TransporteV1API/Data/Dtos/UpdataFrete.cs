namespace TransporteV1API.Data.Dtos;

public class UpdataFrete
{
    public string Origem { get; set; }
    public string Destino { get; set; }
    public float ValorTotal { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
}
