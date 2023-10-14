namespace TrabalhoAPI.Data.ViewModels
{
    public class UsuarioVM
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public List<int>? FilmeIds { get; set; }
        public List<int>? GeneroIds { get; set; }
    }
}