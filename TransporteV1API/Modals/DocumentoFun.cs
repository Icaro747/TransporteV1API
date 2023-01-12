namespace TransporteV1API.Modals
{
    public class DocumentoFun : Entity, IEntity
    {
        public string Tipo { get; set; }
        public DateTime Validade { get; set; }
        public string Documento { get; set; }
        public string Descritivo { get; set; }

        public Guid IdFuncionario { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
