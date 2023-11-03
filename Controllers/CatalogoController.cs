using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.Services;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CatalogoController : ControllerBase
    {

        public CatalogoService _catalogoService;

        public CatalogoController(CatalogoService catalogoService)
        {
            _catalogoService = catalogoService;
        }

        [HttpGet("listar")]

        public IActionResult Listar()
        {
            var allCatalogos = _catalogoService.ListarCatalogos();
            return Ok(allCatalogos);   
        }

        [HttpGet("buscar/{id}")]

        public IActionResult BuscarPorId(int id)
        {
            var catalogo = _catalogoService.ListarCatalogoPorId(id);
            return Ok(catalogo);
        }

        [HttpPost("cadastrar")]

        public IActionResult Cadastrar([FromBody]CatalogoVM catalogo)
        {
            _catalogoService.AdicionarCatalogo(catalogo);
            return Ok();
        }

        [HttpPut("alterar/{id}")]

        public IActionResult AlterarPorId(int id, [FromBody]CatalogoVM catalogo)
        {
            var updateCatalogo = _catalogoService.UpdateCatalogoPorId(id, catalogo);
            return Ok(updateCatalogo);
        }

        [HttpDelete("excluir/{id}")]

        public IActionResult Excluir(int id)
        {
            _catalogoService.DeletarCatalogo(id);
            return Ok();
        }
    }
}