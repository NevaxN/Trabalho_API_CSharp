namespace TrabalhoAPI.Data.Models
{
    public class CatalogoFilme
    {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public string? FilmeTitulo { get; set; }
        public Filme? Filme { get; set; }

        public int CatalogoId { get; set; }
        public Catalogo? Catalogo { get; set; }

    }
}