namespace TransporteV1API.Modals
{
    public class Camiao
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string OMNLink { get; set; }
        public int Capacidade { get; set; }
        public string Discricao { get; set; }
        public Seguro Seguro { get; set; }
        public Financiamento financiamento { get; set; }

    }
}
