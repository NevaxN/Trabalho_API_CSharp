namespace TrabalhoAPI.Data.Models
{
    public class Watchlist
    {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public Filme? Filme { get; set; }
        
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        
    }
}