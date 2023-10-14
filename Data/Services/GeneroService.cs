using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Data.Services
{
    public class GeneroService
    {
        private readonly AppDbContext _context;

        public GeneroService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarGenero(GeneroVM genero)
        {
            var _genero = new Genero()
            {
                GeneroTipo = genero.GeneroTipo,
            };

            _context.Add(_genero);
            _context.SaveChanges();
        }

        public List<Genero> ListarGeneros()
        {
            return _context.Generos.ToList();
        }

        public Genero ListarGeneroPorId(int generoId)
        {
            return _context.Generos.FirstOrDefault(g => g.Id == generoId) ?? new Genero();
        }

        public Genero UpdateGeneroPorId(int generoId, GeneroVM genero)
        {
            var _genero = _context.Generos.FirstOrDefault(g => g.Id == generoId) ?? new Genero();

            if(_genero != null)
            {
                _genero.GeneroTipo = genero.GeneroTipo;

                _context.SaveChanges();
            }
            return _genero ?? new Genero();
        }

        public void DeletarGeneroPorId(int generoId)
        {
            var _genero = _context.Generos.FirstOrDefault(g => g.Id == generoId) ?? new Genero();

            if(_genero != null)
            {
                _context.Generos.Remove(_genero);
                _context.SaveChanges();
            }
        }
    }
}
