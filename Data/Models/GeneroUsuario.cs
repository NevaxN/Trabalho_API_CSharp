namespace TrabalhoAPI.Data.Models
{
    public class GeneroUsuario
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public int GeneroId { get; set; }
        public Genero? Genero { get; set; }
    }
}