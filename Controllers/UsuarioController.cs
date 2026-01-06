using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todo.Context;
using Todo.Models;

namespace Todo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly TodoDbContext _context;
        public record LoginData(string email, string senha);
        public record CadastroData(string nome, string email, string senha);

        public UsuarioController(TodoDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginData data)
        {
            var qry = from usuario in _context.Usuarios
                      where usuario.Email == data.email && usuario.Senha == data.senha
                      select usuario;

            var usuarioEncontrado = await qry.FirstOrDefaultAsync();
            if (usuarioEncontrado == null)
                return Unauthorized();

            return Ok(usuarioEncontrado);
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] CadastroData data)
        {
            var novoUsuario = new Usuario(0, data.nome, data.email, data.senha);
            _context.Usuarios.Add(novoUsuario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(CadastrarUsuario), new { id = novoUsuario.Id }, novoUsuario);
        }
    }
}
