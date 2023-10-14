namespace TrabalhoAPI.Data.Models
{
    public class Diretor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public List<Filme>? Filmes  { get; set; }
    }
}