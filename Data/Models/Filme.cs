namespace TrabalhoAPI.Data.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopse { get; set; }
        public int Ano { get; set; }
        public int DiretorId { get; set; }
        public Diretor? Diretor { get; set; }
        public List<CatalogoFilme>? CatalogoFilmes { get; set; }
        public List<int>? CatalogoIds { get; set; }
        public List<Comentario>? Comentarios { get; set; }
        public List<GeneroFilme>? GeneroFilmes { get; set; }
        
    }
}