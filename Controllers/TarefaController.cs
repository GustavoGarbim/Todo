using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    public class TarefaController : ControllerBase
    {
        [HttpPost("criar")]
        public async Task<IActionResult> CriarTarefa()
        {
            return Ok("Tarefa criada com sucesso!");
        }
    }
}
