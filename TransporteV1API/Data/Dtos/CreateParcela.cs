namespace TransporteV1API.Data.Dtos;

public class CreateParcela
{
    public float Valor { get; set; }
    public DateTime Data { get; set; }
    public Guid IdFrete { get; set; }
}
