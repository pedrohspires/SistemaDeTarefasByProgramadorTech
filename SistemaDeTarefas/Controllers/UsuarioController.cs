using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosOsUsuarios()
        {
            List<UsuarioModel> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarUsuarioPorId(int id)
        {
            UsuarioModel usuarios = await _usuarioRepositorio.BuscarId(id);
            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuario)
        {
            UsuarioModel usuarioResult = await _usuarioRepositorio.Adicionar(usuario);
            return Ok(usuarioResult);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuario, int id)
        {
            usuario.Id = id;
            UsuarioModel usuarioResult = await _usuarioRepositorio.Atualizar(usuario, id);
            return Ok(usuarioResult);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> Apagar([FromBody] UsuarioModel usuario, int id)
        {
            usuario.Id = id;
            bool result = await _usuarioRepositorio.Apagar(id);
            return Ok(result);
        }
    }
}
