using Avaliacao.Application.Dtos;
using Avaliacao.Domain.Entities;
using Bogus;

namespace Avaliacao.Domain.Tests.Domain
{
    internal class GenerateFakerClienteDto
    {
        private static Faker<ClienteDto> CreateClienteDtoFaker()
        {
            return new Faker<ClienteDto>().StrictMode(true)
            .RuleFor(x => x.Id, f => f.Random.Int())
            .RuleFor(x => x.Cpf, f => f.Name.FirstName())
            .RuleFor(x => x.DataNascimento, f => f.Date.Past())
            .RuleFor(x => x.DataCadastro, f => f.Date.Past())
            .RuleFor(x => x.UfNascimento, f => f.Name.FirstName())
            .RuleFor(x => x.Enderecos, f => new List<EnderecoDto> { });
        }
        private static Faker<Cliente> CreateClienteFaker(ClienteDto cliente)
        {
            return new Faker<Cliente>().StrictMode(true)
            .RuleFor(x => x.Id, f => cliente.Id)
            .RuleFor(x => x.Cpf, f => cliente.Cpf)
            .RuleFor(x => x.DataCadastro, f => cliente.DataCadastro)
            .RuleFor(x => x.UfNascimento, f => cliente.UfNascimento)
            .RuleFor(x => x.DataNascimento, f => cliente.DataNascimento)
            .RuleFor(x => x.Enderecos, f => new List<Endereco> {  });
        }
        public static ClienteDto CreateClienteDto()
        {
            return CreateClienteDtoFaker().Generate(); 
        }
        public static Cliente CreateCliente(ClienteDto cliente)
        {
            return CreateClienteFaker(cliente).Generate();
        }
        public static IEnumerable<Cliente> CreateIEnumerableCliente(ClienteDto cliente, int count)
        {
            return CreateClienteFaker(cliente).Generate(count);
        }
    }
}
