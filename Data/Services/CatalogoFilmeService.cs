using TrabalhoAPI.Data.Models;

namespace TrabalhoAPI.Data.Services
{
    public class CatalogoFilmeService
    {
        private readonly AppDbContext _context;
        public CatalogoFilmeService(AppDbContext context)
        {
            _context = context;
        }

        public List<CatalogoFilme> ListarFilmes()
        {
            return _context.CatalogoFilmes.ToList();
        }
    }
}