using TrabalhoAPI.Data.Models;

namespace TrabalhoAPI.Data.Services
{
    public class GeneroUsuarioService
    {
        private readonly AppDbContext _context;
        public GeneroUsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public List<GeneroUsuario> Listar(int usuarioId)
        {
            return _context.GeneroUsuarios.Where(w => w.UsuarioId == usuarioId).ToList();
        }
    }
}