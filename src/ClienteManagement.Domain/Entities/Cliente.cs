namespace ClienteManagement.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string Porte { get; set; } // Porte(Pequena, Media, Grande)
    }
}
