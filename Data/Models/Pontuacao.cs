namespace TrabalhoAPI.Data.Models
{
    public class Pontuacao
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public int FilmeId { get; set; }
        public Filme? Filme { get; set; }
    }
}