using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data.Services;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComentarioController : ControllerBase
    {
        private readonly ComentarioService _comentarioService;

        public ComentarioController(ComentarioService comentarioService)
        {
            _comentarioService = comentarioService;
        }

        [HttpGet("listar")]

        public IActionResult Listar()
        {
            var allComentarios = _comentarioService.ListarComentarios();
            return Ok(allComentarios);
        }

        [HttpGet("buscar/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var comentario = _comentarioService.ListarComentarioPorId(id);
            return Ok(comentario);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody]ComentarioVM comentario)
        {
            _comentarioService.AdicionarComentario(comentario);

            return Ok();
        }

        [HttpPut("alterar/{id}")]
        public IActionResult Alterar(int id, [FromBody]ComentarioVM comentario)
        {
            var updateComentario = _comentarioService.UpdateComentarioPorId(id, comentario);
            return Ok(updateComentario);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _comentarioService.DeletarComentarioPorId(id);
            return Ok();
        }
    }
}
