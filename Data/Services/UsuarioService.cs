using Microsoft.AspNetCore.Http.HttpResults;
using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Data.Services
{
    public class UsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarUsuario(UsuarioVM usuario)
        {
            var _usuario = new Usuario()
            {
                Nome = usuario.Nome,
                Login = usuario.Login,
                Senha = usuario.Senha
            };

            _context.Add(_usuario);
            _context.SaveChanges();

            foreach(var id in usuario.FilmeIds)
            {
                var _watchlist = new Watchlist()
                {
                    UsuarioId = _usuario.Id,
                    FilmeId = id
                };
                _context.Watchlists.Add(_watchlist);
                _context.SaveChanges();
            }

            foreach(var id in usuario.GeneroIds)
            {
                var _genero_usuario = new GeneroUsuario()
                {
                    UsuarioId = _usuario.Id,
                    GeneroId = id
                };
                _context.GeneroUsuarios.Add(_genero_usuario);
                _context.SaveChanges();
            }
        }

        public List<Usuario> ListarUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario ListarUsuarioPorId(int usuarioId)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(u => u.Id == usuarioId) ?? throw new KeyNotFoundException("Usuário não encontrado");
            return usuario;
        }

        public Usuario UpdateUsuarioPorId(int usuarioId, UsuarioVM usuario)
        {
            var _usuario = _context.Usuarios.FirstOrDefault(u => u.Id == usuarioId);

            if(_usuario != null)
            {
                _usuario.Nome = usuario.Nome;
                _usuario.Login = usuario.Login;
                _usuario.Senha = usuario.Senha;

                _context.SaveChanges();
            }

            return _usuario ?? new Usuario();
        }

        public void DeletarUsuarioPorId(int usuarioId)
        {
            var _usuario = _context.Usuarios.FirstOrDefault(u => u.Id == usuarioId);

            if(_usuario != null)
            {
                _context.Usuarios.Remove(_usuario);
                _context.SaveChanges();
            }
        }
    }
}