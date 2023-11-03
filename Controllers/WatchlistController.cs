using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data.Services;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WatchlistController : ControllerBase
    {
        private readonly WatchlistService _watchlistService;
        private readonly GeneroUsuarioService _generoUsuarioService;

        public WatchlistController(WatchlistService watchlistService, GeneroUsuarioService generoUsuarioService)
        {
            _watchlistService = watchlistService;
            _generoUsuarioService = generoUsuarioService;
        }

        [HttpGet("listar")]

        public IActionResult Listar()
        {
            var allWatchlists = _watchlistService.ListarFilmes();
            return Ok(allWatchlists);
        }

        [HttpPost("listarGeneroUsuario")]
        public IActionResult ListarGeneroUsuario(int usuarioId)
        {
            return Ok(_generoUsuarioService.Listar(usuarioId));
        }
    }
}