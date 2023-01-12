namespace TransporteV1API.Modals
{
    public class Caminhao : Entity, IEntity
    {
        public string Nome { get; set; }
        public string Placa { get; set; }
        public string OmnLink { get; set; }
        public string Crv { get; set; }
        public string Tipo { get; set; }
        public int Capacidade { get; set; }
        public string Discricao { get; set; }

        public virtual Financiamento Financiamento { get; set; }
        public virtual Seguro Seguro { get; set; }
        public virtual ICollection<Gasto> Gastos { get; set; }
        public virtual ICollection<Frete> Fretes { get; set; }
    }
}
