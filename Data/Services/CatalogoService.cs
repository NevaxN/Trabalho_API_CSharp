using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Data.Services
{
    public class CatalogoService
    {
        private AppDbContext _context;
        public CatalogoService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarCatalogo(CatalogoVM catalogo)
        {
            var _catalogo = new Catalogo(){
                Descricao = catalogo.Descricao
            };
            _context.Add(_catalogo);
            _context.SaveChanges();
        }

        public List<Catalogo> ListarCatalogos()
        {
            return _context.Catalogos.ToList();
        }

        public Catalogo ListarCatalogoPorId(int catalogoId)
        {
            return _context.Catalogos.FirstOrDefault(c => c.Id == catalogoId) ?? new Catalogo();
        }

        public Catalogo UpdateCatalogoPorId(int catalogoId, CatalogoVM catalogo)
        {
            var _catalogo = _context.Catalogos.FirstOrDefault(c => c.Id == catalogoId);

            if(_catalogo != null)
            {
                _catalogo.Descricao = catalogo.Descricao;

                _context.SaveChanges();
            }

            return _catalogo ?? new Catalogo();
        }

        public void DeletarCatalogo(int catalogoId)
        {
            var _catalogo = _context.Catalogos.FirstOrDefault(c => c.Id == catalogoId);

            if(_catalogo != null)
            {
                _context.Catalogos.Remove(_catalogo);
                _context.SaveChanges();
            }
        }
    }
}