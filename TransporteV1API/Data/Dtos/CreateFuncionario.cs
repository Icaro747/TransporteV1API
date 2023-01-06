namespace TransporteV1API.Data.Dtos;

public class CreateFuncionario
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Cargo { get; set; }
    public float Salario { get; set; }
}
