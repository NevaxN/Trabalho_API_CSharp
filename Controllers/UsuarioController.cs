using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data.Services;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        public UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        
        [HttpGet("listar")]
        public IActionResult Listar()
        {
            var allUsuarios = _usuarioService.ListarUsuarios();
            return Ok(allUsuarios);
        }

        [HttpGet("buscar/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var usuario = _usuarioService.ListarUsuarioPorId(id);
            return Ok(usuario);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody]UsuarioVM usuario)
        {
            _usuarioService.AdicionarUsuario(usuario);
            return Ok();
        }

        [HttpPut("alterar/{id}")]
        public IActionResult Alterar(int id, [FromBody]UsuarioVM usuario)
        {
            var updateUsuario = _usuarioService.UpdateUsuarioPorId(id, usuario);
            return Ok(updateUsuario);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _usuarioService.DeletarUsuarioPorId(id);
            return Ok();
        }
    }
}