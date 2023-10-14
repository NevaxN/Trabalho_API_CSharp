using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data.Services;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PontuacaoController : ControllerBase
    {
        public PontuacaoService _pontuacaoService;

        public PontuacaoController(PontuacaoService pontuacaoService)
        {
            _pontuacaoService = pontuacaoService;
        }

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            var allPontuacoes = _pontuacaoService.ListarPontuacao();
            return Ok(allPontuacoes);
        }

        [HttpGet("buscar/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var pontuacao = _pontuacaoService.ListarPontuacaoPorId(id);
            return Ok(pontuacao);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody]PontuacaoVM pontuacao)
        {
            _pontuacaoService.AdicionarPontuacao(pontuacao);
            return Ok();
        }

        [HttpPut("alterar/{id}")]
        public IActionResult Alterar(int id, [FromBody]PontuacaoVM pontuacao)
        {
            var updatePontuacao = _pontuacaoService.UpdatePontuacaoPorId(id, pontuacao);
            return Ok(updatePontuacao);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _pontuacaoService.DeletarPontuacaoPorId(id);
            return Ok();
        }
    }
}