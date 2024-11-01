using System.Text.Json.Serialization;

namespace Avaliacao.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public DateTime DataCadastro { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public Cliente? Cliente { get; set; }
    }
}
