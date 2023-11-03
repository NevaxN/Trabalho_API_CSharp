using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Data.Services
{
    public class ComentarioService
    {
        private readonly AppDbContext _context;

        public ComentarioService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarComentario(ComentarioVM comentario)
        {
            var _comentario = new Comentario(){
                Texto = comentario.Texto,
                UsuarioId = comentario.UsuarioId,
                FilmeId = comentario.FilmeId
            };
            _context.Comentarios.Add(_comentario);
            _context.SaveChanges();
        }

        public List<Comentario> ListarComentarios()
        {
            return _context.Comentarios.ToList();
        }

        public Comentario ListarComentarioPorId(int comentarioId)
        {
            return _context.Comentarios.FirstOrDefault(c => c.Id == comentarioId) ?? new Comentario();
        }

        public Comentario UpdateComentarioPorId(int comentarioId, ComentarioVM comentario)
        {
            var _comentario = _context.Comentarios.FirstOrDefault(c => c.Id == comentarioId);

            if(_comentario != null)
            {
                _comentario.Texto = comentario.Texto;

                _context.SaveChanges();
            }
            return _comentario ?? new Comentario();
        }

        public void DeletarComentarioPorId(int comentarioId)
        {
            var _comentario = _context.Comentarios.FirstOrDefault(c => c.Id == comentarioId);

            if(_comentario != null)
            {
                _context.Comentarios.Remove(_comentario);
                _context.SaveChanges();
            }
        }
    }
}