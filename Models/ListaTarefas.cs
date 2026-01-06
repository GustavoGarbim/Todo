namespace Todo.Models
{
    public class ListaTarefas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
