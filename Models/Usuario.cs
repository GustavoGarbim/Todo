namespace Todo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; private set; }

        public virtual ICollection<ListaTarefas> Listas { get; set; }

        public void SetSenha(string senha)
        {
            Senha = senha;
        }

        public Usuario(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}
