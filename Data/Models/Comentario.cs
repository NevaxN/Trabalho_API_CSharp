namespace TrabalhoAPI.Data.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public int FilmeId { get; set; }
        public Filme? Filme { get; set; }
    }
}