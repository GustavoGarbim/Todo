using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    public class TarefaController : ControllerBase
    {
        [HttpPost("criar")]
        public async Task<IActionResult> CriarTarefa()
        {
            // Todo: Implementar a lógica para criar uma nova tarefa
            return Ok("Tarefa criada com sucesso!");
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarTarefas()
        {
            // Todo: Implementar a lógica para listar todas as tarefas
            return Ok("Tarefa criada com sucesso!");
        }

        [HttpDelete("deletar/{id}")]
        public async Task<IActionResult> DeletarTarefa(int id)
        {
            // Todo: Implementar a lógica para deletar uma tarefa pelo ID
            return Ok("Tarefa deletada com sucesso!");
        }
    }
}
