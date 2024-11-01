using System.Text.Json.Serialization;

namespace Avaliacao.Application.Dtos
{
    public class EnderecoDto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public DateTime DataCadastro { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public ClienteDto? Cliente { get; set; }
    }
}
