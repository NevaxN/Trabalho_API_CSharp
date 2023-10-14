namespace TrabalhoAPI.Data.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public List<Watchlist>? Watchlists { get; set; }
        public List<GeneroUsuario>? GeneroUsuarios { get; set; }
        public List<int>? FilmeIds { get; set; }
    }
}