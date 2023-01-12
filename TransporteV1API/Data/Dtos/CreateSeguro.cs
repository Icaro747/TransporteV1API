namespace TransporteV1API.Data.Dtos;

public class CreateSeguro
{
    public string Numero { get; set; }
    public float Valor { get; set; }
    public DateTime DataVencimento { get; set; }
    public Guid IdCaminhao { get; set; }
}
