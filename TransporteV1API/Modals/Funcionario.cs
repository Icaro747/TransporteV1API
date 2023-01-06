namespace TransporteV1API.Modals
{
    public class Funcionario : Entity, IEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public float Salario { get; set; }

        public virtual ICollection<DocumentoFun> Documentos { get; set; }
    }
}
