using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data.Services;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroController : ControllerBase
    {
        private readonly GeneroService _generoService;

        public GeneroController(GeneroService generoService)
        {
            _generoService = generoService;
        }

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            var allGeneros = _generoService.ListarGeneros();
            return Ok(allGeneros);
        }

        [HttpGet("buscar/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var genero = _generoService.ListarGeneroPorId(id);
            return Ok(genero);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody]GeneroVM genero)
        {
            _generoService.AdicionarGenero(genero);
            return Ok();
        }

        [HttpPut("alterar/{id}")]
        public IActionResult Alterar(int id, [FromBody]GeneroVM genero)
        {
            var updateGenero = _generoService.UpdateGeneroPorId(id, genero);
            return Ok(updateGenero);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _generoService.DeletarGeneroPorId(id);
            return Ok();
        }
    }
}
