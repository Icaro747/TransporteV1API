namespace TransporteV1API.Modals
{
    public class Frete : Entity, IEntity
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public float ValorTotal { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Guid IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public Guid IdCaminhao { get; set; }
        public virtual Caminhao Caminhao { get; set; }
        public virtual ICollection<Parcela> Parcelas { get; set; }
        public virtual ICollection<Equipe> Equipes { get; set; }

    }
}
