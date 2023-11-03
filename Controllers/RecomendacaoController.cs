using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.Services;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecomendacaoController : ControllerBase
    {
        private readonly GeneroUsuarioService _generoUsuarioService;
        private readonly FilmesService _filmesService;
        private readonly WatchlistService _watchlistService;
        private readonly UsuarioService _usuarioService;

        public RecomendacaoController(GeneroUsuarioService generoUsuarioService, FilmesService filmesService, WatchlistService watchlistService, UsuarioService usuarioService)
        {
            _generoUsuarioService = generoUsuarioService;
            _filmesService = filmesService;
            _watchlistService = watchlistService;
            _usuarioService = usuarioService;
        }

        [HttpPost("recomendacao")]
        public IActionResult ListarRecomendacao(int usuarioId)
        {
            try
            {
                Usuario usuario = _usuarioService.ListarUsuarioPorId(usuarioId);
            }
            catch (KeyNotFoundException)
            {
                
                return NotFound("Usuário não encontrado");
            }
            //lista de generos do usuario
            List<GeneroUsuario> generoUsuarios = _generoUsuarioService.Listar(usuarioId);
            List<int> fields = generoUsuarios.Select(s => new { s.GeneroId }).Select(a => a.GeneroId).ToList();
            //lista filmes dos generos
            List<Filme> filmes = _filmesService.ListarFilmePorGenero(fields);
            //lista filmes vistos do usuario
            List<Watchlist> watchlists = _watchlistService.ListarFilmesPorUsuario(usuarioId);
            List<int> vistos = watchlists.Select(s => new { s.FilmeId }).Select(a => a.FilmeId).ToList();
            //filtra os filmes nao vistos
            return Ok(filmes.Where(f => !vistos.Contains(f.Id)).ToList());
        }
    }
}