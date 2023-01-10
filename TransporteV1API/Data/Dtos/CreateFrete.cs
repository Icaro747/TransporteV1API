using TransporteV1API.Modals;

namespace TransporteV1API.Data.Dtos;

public class CreateFrete
{
    public string Origem { get; set; }
    public string Destino { get; set; }
    public float ValorTotal { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public Guid IdCliente { get; set; }
    public Guid IdCaminhao { get; set; }
}
