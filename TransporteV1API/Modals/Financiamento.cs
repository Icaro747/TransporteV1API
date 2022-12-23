namespace TransporteV1API.Modals
{
    public class Financiamento
    {
        public int Id { get; set; }
        public string Financiador { get; set; }
        public string Banco { get; set; }
        public float ValorTotal { get; set; }
        public float ValorMensal { get; set; }
        public float ValorPago { get; set; }
        public int QtdParcelas { get; set; }
        public DateTime DataInicio { get; set; }

        public int IdCamiao { get; set; }
        public Camiao camiao { get; set; }
    }
}