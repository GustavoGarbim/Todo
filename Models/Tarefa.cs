namespace Todo.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int ListaId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsFinished { get; set; }

        public virtual ListaTarefas Lista { get; set; }
    }
}
