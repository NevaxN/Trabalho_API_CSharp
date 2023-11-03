using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Data.Services
{
    public class FilmesService
    {

        private readonly AppDbContext _context;
        public FilmesService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarFilme(FilmeVM filme)
        {
            var _filme = new Filme(){
                Titulo = filme.Titulo,
                Sinopse = filme.Sinopse,
                Ano = filme.Ano,
                DiretorId = filme.DiretorId
            };
            _context.Add(_filme);
            _context.SaveChanges();

            //Relação Filme - Catalogo (CatalogoFilme)
            foreach(var id in filme.CatalogoIds)
            {
                var _catalogo_filme = new CatalogoFilme() 
                {
                    FilmeId = _filme.Id,
                    FilmeTitulo = _filme.Titulo,
                    CatalogoId = id
                };
                _context.CatalogoFilmes.Add(_catalogo_filme);
                _context.SaveChanges();
            }

            foreach(var id in filme.GeneroIds)
            {
                var _genero_filme = new GeneroFilme() 
                {
                    FilmeId = _filme.Id,
                    GeneroId = id
                };
                _context.GeneroFilmes.Add(_genero_filme);
                _context.SaveChanges();
            }
        }

        public List<Filme> ListarFilmes()
        {
            return _context.Filmes.ToList();
        }

        public Filme ListarFilmePorId(int filmeId)
        {
            return _context.Filmes.FirstOrDefault(f => f.Id == filmeId) ?? new Filme();
        }

        public Filme UpdateFilmePorId(int filmeId, FilmeVM filme)
        {
            var _filme = _context.Filmes.FirstOrDefault(f => f.Id == filmeId);
            if(_filme != null)
            {
                _filme.Titulo = filme.Titulo;
                _filme.Sinopse = filme.Sinopse;
                _filme.Ano = filme.Ano;

                _context.SaveChanges();
            }

            return _filme ?? new Filme();
        }

        public void DeletarFilme(int filmeId)
        {
            var _filme = _context.Filmes.FirstOrDefault(f => f.Id == filmeId);
            
            if(_filme != null)
            {
                _context.Filmes.Remove(_filme);
                _context.SaveChanges();
            }
        }

        public List<Filme> ListarFilmePorGenero(List<int> generos)
        {
            //List<int> fields = generos.Select(s => new { s.Id }).Select(a => a.Id).ToList();
            List<GeneroFilme> generoFilmes = _context.GeneroFilmes.Where(g => generos.Contains(g.GeneroId)).ToList();
            List<int> filmes = generoFilmes.Select(s => new { s.Id }).Select(a => a.Id).ToList();

            return _context.Filmes.Where(g => filmes.Contains(g.Id)).ToList();
        }
    }
}