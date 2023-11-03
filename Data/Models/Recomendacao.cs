namespace TrabalhoAPI.Data.Models
{
    public class Recomendacao
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}