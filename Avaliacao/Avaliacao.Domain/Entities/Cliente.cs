namespace Avaliacao.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UfNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}
