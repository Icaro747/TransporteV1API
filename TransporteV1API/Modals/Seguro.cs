namespace TransporteV1API.Modals
{
    public class Seguro : Entity, IEntity
    {
        public string Numero { get; set; }
        public float Valor { get; set; }
        public DateTime DataVencimento { get; set; }

        public Guid IdCaminhao { get; set; }
        public virtual Caminhao Caminhao { get; set; }
    }
}