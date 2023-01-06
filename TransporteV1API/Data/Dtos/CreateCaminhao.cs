using System.ComponentModel.DataAnnotations;

namespace TransporteV1API.Data.Dtos;

public class CreateCaminhao
{
    [Required]
    [StringLength(100)]
    public string Nome { get; set; }
    [Required]
    public string Placa { get; set; }
    [Required]
    public string OmnLink { get; set; }
    [Required]
    public string Crv { get; set; }
    [Required]
    public string Tipo { get; set; }
    public int Capacidade { get; set; }
    public string Discricao { get; set; }
}
