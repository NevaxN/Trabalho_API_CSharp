using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabalhoAPI.Data;
using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.Services;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class DiretorController : ControllerBase
    {
        public DiretorService _diretorService;

        public DiretorController(DiretorService diretorService)
        {
            _diretorService = diretorService;
        }

        [HttpGet("listar")]

        public IActionResult Listar()
        {
            var allDiretores = _diretorService.ListarDiretores();
            return Ok(allDiretores);   
        }

        [HttpGet("buscar/{id}")]

        public IActionResult Buscar(int id)
        {
            var diretor = _diretorService.ListarDiretorPorId(id);
            return Ok(diretor);
        }

        [HttpPost("cadastrar")]

        public IActionResult Cadastrar([FromBody]DiretorVM diretor)
        {
            _diretorService.AdicionarDiretor(diretor);   
            return Ok();
        }

        [HttpPut("alterar/{id}")]

        public IActionResult AlterarPorId(int id, [FromBody]DiretorVM diretor)
        {
            var updateDiretor = _diretorService.UpdateDiretorPorId(id, diretor);
            return Ok(updateDiretor);
        }

        [HttpDelete("excluir/{id}")]

        public IActionResult Excluir(int id)
        {
            _diretorService.DeletarDiretor(id);
            return Ok();
        }
    }
}