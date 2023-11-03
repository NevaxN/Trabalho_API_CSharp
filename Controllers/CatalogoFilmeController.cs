using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data.Services;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogoFilmeController : ControllerBase
    {
        public CatalogoFilmeService _catalogoFilmeService;

        public CatalogoFilmeController(CatalogoFilmeService catalogoFilmeService)
        {
            _catalogoFilmeService = catalogoFilmeService;
        }

        [HttpGet("listar")]

        public IActionResult Listar()
        {
            var allCatalogoFilmes = _catalogoFilmeService.ListarFilmes();
            return Ok(allCatalogoFilmes);
        }
    }
}