using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.Services;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class FilmesController : ControllerBase
    {

        public FilmesService _filmeService;

        public FilmesController(FilmesService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpGet("listar")]

        public IActionResult Listar()
        {
            var allFilmes = _filmeService.ListarFilmes();
            return Ok(allFilmes);
        }

        [HttpGet("buscar/{id}")]

        public IActionResult BuscarPorId(int id)
        {
            var filme = _filmeService.ListarFilmePorId(id);
            return Ok(filme);
        }

        [HttpPost("cadastrar")]

        public IActionResult Cadastrar([FromBody]FilmeVM filme)
        {   
            _filmeService.AdicionarFilme(filme);

            return Ok();
        }

        [HttpPut("alterar/{id}")]

        public IActionResult Alterar(int id, [FromBody]FilmeVM filme)
        {
            var updateFilme = _filmeService.UpdateFilmePorId(id, filme);
            return Ok(updateFilme);
        }

        [HttpDelete("excluir/{id}")]

        public IActionResult Excluir(int id)
        {
            _filmeService.DeletarFilme(id);
            return Ok();
        }

        [HttpPost("listarFilmePorGenero")]
        public IActionResult ListarFilmePorGenero(List<int> generos)
        {
            return Ok(_filmeService.ListarFilmePorGenero(generos));
        }
    }
}