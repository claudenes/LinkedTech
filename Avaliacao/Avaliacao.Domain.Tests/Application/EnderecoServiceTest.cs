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
    public class EnderecoServiceTest
    {
        private readonly IEnderecoRepository _repository;
        private readonly IEnderecoService _service;

        public EnderecoServiceTest()
        {
            _repository = Substitute.For<IEnderecoRepository>();
            _service = new EnderecoService(_repository, GenerateFakerMapper.AddMapperConfiguration());
        }
        [Fact]
        public void Constructor()
        {
            var result = new EnderecoService(_repository, GenerateFakerMapper.AddMapperConfiguration());
            result.Should().NotBeNull();

        }
        [Fact]
        public void Create() 
        {
            EnderecoDto EnderecoDto = GenerateFakerEnderecoDto.CreateEnderecoDto();
            Endereco Endereco = GenerateFakerEnderecoDto.CreateEndereco(EnderecoDto);
            List<Endereco> queryEndereco = new();
            _repository.ReadAll().Where(x=>x.Id==EnderecoDto.Id).Returns(queryEndereco);

            var result = _repository.Create(Endereco).Returns(Endereco);
            var result2 = _service.Create(EnderecoDto);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Read()
        {
            EnderecoDto EnderecoDto = GenerateFakerEnderecoDto.CreateEnderecoDto();
            Endereco Endereco = GenerateFakerEnderecoDto.CreateEndereco(EnderecoDto);
            List<Endereco> queryEndereco = new();
            _repository.ReadAll().Where(x => x.Id == EnderecoDto.Id).Returns(queryEndereco);

            var result = _repository.ReadById(Endereco.Id).Returns(Endereco);
            var result2 = _service.Read(EnderecoDto.Id);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Delete()
        {
            EnderecoDto EnderecoDto = GenerateFakerEnderecoDto.CreateEnderecoDto();
            Endereco Endereco = GenerateFakerEnderecoDto.CreateEndereco(EnderecoDto);
            List<Endereco> queryEndereco = new();
            _repository.ReadAll().Where(x => x.Id == EnderecoDto.Id).Returns(queryEndereco);

            var result = _repository.Delete(Endereco.Id).Returns(Endereco);
            var result2 = _service.Delete(EnderecoDto.Id);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Update()
        {
            EnderecoDto EnderecoDto = GenerateFakerEnderecoDto.CreateEnderecoDto();
            Endereco Endereco = GenerateFakerEnderecoDto.CreateEndereco(EnderecoDto);
            List<Endereco> queryEndereco = new();
            _repository.ReadAll().Where(x => x.Id == EnderecoDto.Id).Returns(queryEndereco);

            var result = _repository.Update(Endereco).Returns(Endereco);
            var result2 = _service.Update(EnderecoDto);

            result.Should().NotBeNull();
        }
        [Fact]
        public void ListAll()
        {
            EnderecoDto EnderecoDto = GenerateFakerEnderecoDto.CreateEnderecoDto();
            IEnumerable<Endereco> eEndereco = GenerateFakerEnderecoDto.CreateIEnumerableEndereco(EnderecoDto,1);
            ICollection<Endereco> CEndereco = eEndereco.ToList();

            _repository.ReadAll().Returns(CEndereco);


            var result = _service.ListAll();
            result.Should().NotBeNull();
        }
    }
}
