namespace TransporteV1API.Modals
{
    public class Parcela : Entity, IEntity
    {
        public float Valor { get; set; }
        public DateTime Data { get; set; }

        public Guid IdFrete { get; set; }
        public virtual Frete Frete { get; set; }
    }
}
