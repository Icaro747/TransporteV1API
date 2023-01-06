namespace TransporteV1API.Data.Dtos;

public class CreateGasto
{
    public string Tipo { get; set; }
    public string Descricao { get; set; }
    public float Valor { get; set; }
    public DateTime Data { get; set; }
    public Guid IdCamiao { get; set; }
}
