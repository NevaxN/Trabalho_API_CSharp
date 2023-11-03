namespace TrabalhoAPI.Data.ViewModels
{
    public class FilmeVM
    {
        public string? Titulo { get; set; }
        public string? Sinopse { get; set; }
        public int Ano { get; set; }

        public int DiretorId { get; set; }
        public List<int>? GeneroIds { get; set; }
        public List<int>? CatalogoIds { get; set; }
    }
}