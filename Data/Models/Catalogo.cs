namespace TrabalhoAPI.Data.Models
{
    public class Catalogo
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }

        public List<CatalogoFilme>? CatalogoFilmes { get; set; }
    }
}