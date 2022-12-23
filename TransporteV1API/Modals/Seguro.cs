namespace TransporteV1API.Modals
{
    public class Seguro
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public float Valor { get; set; }
        public DateTime DataVencimento { get; set; }

        public int IdCamiao { get; set; }
        public Camiao camiao { get; set; }
    }
}