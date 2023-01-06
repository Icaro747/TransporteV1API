namespace TransporteV1API.Modals
{
    public class Gasto : Entity, IEntity
    {
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public DateTime Data { get; set; }

        public Guid IdCamiao { get; set; }
        public virtual Caminhao Caminhao { get; set; }
    }
}