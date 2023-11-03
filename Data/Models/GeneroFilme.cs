namespace TrabalhoAPI.Data.Models
{
    public class GeneroFilme
    {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public Filme? Filme { get; set; }
        public int GeneroId { get; set; }
        public Genero? Genero { get; set; }
    }
}