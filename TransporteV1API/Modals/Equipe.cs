namespace TransporteV1API.Modals
{
    public class Equipe : Entity, IEntity
    {
        public float Comissao { get; set; }
        
        public Guid IdFuncionario { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public Guid IdFrete { get; set; }
        public virtual Frete Frete { get; set; }
    }
}
