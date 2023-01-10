namespace TransporteV1API.Modals
{
    public class Cliente : Entity, IEntity
    {
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string NomeContato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Frete> Fretes { get; set; }

    }
}
