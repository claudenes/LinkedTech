using Avaliacao.Application.Dtos;
using Avaliacao.Domain.Entities;
using Bogus;

namespace Avaliacao.Domain.Tests.Domain
{
    internal class GenerateFakerEnderecoDto
    {
        private static Faker<EnderecoDto> CreateEnderecoDtoFaker()
        {
            return new Faker<EnderecoDto>().StrictMode(true)
            .RuleFor(x => x.Id, f => f.Random.Int())
            .RuleFor(x => x.ClienteId, f => f.Random.Int())
            .RuleFor(x => x.Logradouro, f => f.Name.FirstName())
            .RuleFor(x => x.Cidade, f => f.Name.FirstName())
            .RuleFor(x => x.Bairro, f => f.Name.FirstName())
            .RuleFor(x => x.DataCadastro, f => f.Date.Past())
            .RuleFor(x => x.Uf, f => f.Name.FirstName());
        }
        private static Faker<Endereco> CreateEnderecoFaker(EnderecoDto endereco)
        {
            return new Faker<Endereco>().StrictMode(true)
            .RuleFor(x => x.Id, f => endereco.Id)
            .RuleFor(x => x.ClienteId, f => endereco.ClienteId)
            .RuleFor(x => x.Logradouro, f => endereco.Logradouro)
            .RuleFor(x => x.Cidade, f => endereco.Cidade)
            .RuleFor(x => x.Bairro, f => endereco.Bairro)
            .RuleFor(x => x.DataCadastro, f => endereco.DataCadastro)
            .RuleFor(x => x.Uf, f => endereco.Uf);
        }
        public static EnderecoDto CreateEnderecoDto()
        {
            return CreateEnderecoDtoFaker().Generate(); 
        }
        public static Endereco CreateEndereco(EnderecoDto endereco)
        {
            return CreateEnderecoFaker(endereco).Generate();
        }
        public static IEnumerable<Endereco> CreateIEnumerableEndereco(EnderecoDto endereco, int count)
        {
            return CreateEnderecoFaker(endereco).Generate(count);
        }
    }
}
