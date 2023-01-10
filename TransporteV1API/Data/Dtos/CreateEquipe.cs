namespace TransporteV1API.Data.Dtos;

public class CreateEquipe
{
    public float Comissao { get; set; }
    public Guid IdFuncionario { get; set; }
    public Guid IdFrete { get; set; }
}
