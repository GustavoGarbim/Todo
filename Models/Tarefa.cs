namespace Todo.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsFinished { get; set; }
    }
}
