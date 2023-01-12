namespace TransporteV1API.Data.Dtos
{
    public class UpdataFinanciamento
    {
        public string Financiador { get; set; }
        public string Banco { get; set; }
        public float ValorTotal { get; set; }
        public float ValorMensal { get; set; }
        public float ValorPago { get; set; }
        public int QtdParcelas { get; set; }
        public DateTime DataInicio { get; set; }
    }
}
