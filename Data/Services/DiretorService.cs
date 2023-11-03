using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Data.Services
{
    public class DiretorService
    {
        private AppDbContext _context;
        public DiretorService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarDiretor(DiretorVM diretor)
        {
            var _diretor = new Diretor(){
                Nome = diretor.Nome
            };
            _context.Add(_diretor);
            _context.SaveChanges();
        }

        public List<Diretor> ListarDiretores()
        {
            return _context.Diretores.ToList();
        }

        public Diretor ListarDiretorPorId(int diretorId)
        {
            return _context.Diretores.FirstOrDefault(d => d.Id == diretorId) ?? new Diretor();
        }

        public Diretor UpdateDiretorPorId(int diretorId, DiretorVM diretor)
        {
            var _diretor = _context.Diretores.FirstOrDefault(d => d.Id == diretorId);

            if(_diretor != null)
            {
                _diretor.Nome = diretor.Nome;

                _context.SaveChanges();
            }
            return _diretor ?? new Diretor();
        }

        public void DeletarDiretor(int diretorId)
        {
            var _diretor = _context.Diretores.FirstOrDefault(d => d.Id == diretorId);

            if(_diretor != null)
            {
                _context.Diretores.Remove(_diretor);
                _context.SaveChanges();
            }
        }
    }
}