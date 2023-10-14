using TrabalhoAPI.Data.Models;

namespace TrabalhoAPI.Data.Services
{
    public class WatchlistService
    {
        private readonly AppDbContext _context;
        public WatchlistService(AppDbContext context)
        {
            _context = context;
        }

        public List<Watchlist> ListarFilmes()
        {
            return _context.Watchlists.ToList();
        }

        public List<Watchlist> ListarFilmesPorUsuario(int usuarioId)
        {
            return _context.Watchlists.Where(w => w.UsuarioId == usuarioId).ToList();
        }
    }
}