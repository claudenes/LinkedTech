using Avaliacao.Application.Dtos;
using Avaliacao.Application.Interfaces;
using Avaliacao.Application.Services;
using Avaliacao.Domain.Entities;
using Avaliacao.Domain.Interfaces;
using Avaliacao.Domain.Tests.Common;
using Avaliacao.Domain.Tests.Domain;
using FluentAssertions;
using FluentValidation;
using NSubstitute;
using Xunit;

namespace Avaliacao.Domain.Tests.Application
{
    public class ClienteServiceTest
    {
        private readonly IClienteRepository _repository;
        private readonly IClienteService _service;

        public ClienteServiceTest()
        {
            _repository = Substitute.For<IClienteRepository>();
            _service = new ClienteService(_repository, GenerateFakerMapper.AddMapperConfiguration());
        }
        [Fact]
        public void Constructor()
        {
            var result = new ClienteService(_repository, GenerateFakerMapper.AddMapperConfiguration());
            result.Should().NotBeNull();

        }
        [Fact]
        public void Create() 
        {
            ClienteDto ClienteDto = GenerateFakerClienteDto.CreateClienteDto();
            Cliente Cliente = GenerateFakerClienteDto.CreateCliente(ClienteDto);
            List<Cliente> queryCliente = new();
            _repository.ReadAll().Where(x=>x.Id==ClienteDto.Id).Returns(queryCliente);

            var result = _repository.Create(Cliente).Returns(Cliente);
            var result2 = _service.Create(ClienteDto);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Read()
        {
            ClienteDto ClienteDto = GenerateFakerClienteDto.CreateClienteDto();
            Cliente Cliente = GenerateFakerClienteDto.CreateCliente(ClienteDto);
            List<Cliente> queryCliente = new();
            _repository.ReadAll().Where(x => x.Id == ClienteDto.Id).Returns(queryCliente);

            var result = _repository.ReadById(Cliente.Id).Returns(Cliente);
            var result2 = _service.Read(ClienteDto.Id);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Delete()
        {
            ClienteDto ClienteDto = GenerateFakerClienteDto.CreateClienteDto();
            Cliente Cliente = GenerateFakerClienteDto.CreateCliente(ClienteDto);
            List<Cliente> queryCliente = new();
            _repository.ReadAll().Where(x => x.Id == ClienteDto.Id).Returns(queryCliente);

            var result = _repository.Delete(Cliente.Id).Returns(Cliente);
            var result2 = _service.Delete(ClienteDto.Id);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Update()
        {
            ClienteDto ClienteDto = GenerateFakerClienteDto.CreateClienteDto();
            Cliente Cliente = GenerateFakerClienteDto.CreateCliente(ClienteDto);
            List<Cliente> queryCliente = new();
            _repository.ReadAll().Where(x => x.Id == ClienteDto.Id).Returns(queryCliente);

            var result = _repository.Update(Cliente).Returns(Cliente);
            var result2 = _service.Update(ClienteDto);

            result.Should().NotBeNull();
        }
        [Fact]
        public void ListAll()
        {
            ClienteDto ClienteDto = GenerateFakerClienteDto.CreateClienteDto();
            IEnumerable<Cliente> eCliente = GenerateFakerClienteDto.CreateIEnumerableCliente(ClienteDto,1);
            ICollection<Cliente> CCliente = eCliente.ToList();

            _repository.ReadAll().Returns(CCliente);


            var result = _service.ListAll();
            result.Should().NotBeNull();
        }
    }
}
