namespace Funcionarios.Models
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Funcao { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(Guid id, string nome, string sobrenome, string funcao, decimal salario)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Funcao = funcao;
            Salario = salario;
        }
    }
}
