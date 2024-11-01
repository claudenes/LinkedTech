using Avaliacao.API.Controllers;
using Avaliacao.Application.Dtos;
using Avaliacao.Application.Interfaces;
using Avaliacao.Domain.Tests.Domain;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Avaliacao.Domain.Tests.Controller
{
    public class ClienteControllerTest
    {
        private readonly IClienteService _service;
        private readonly ClienteController _controller;
        public ClienteControllerTest()
        {
            _service = Substitute.For<IClienteService>();
            _controller = new ClienteController(_service);
        }
        [Fact]
        public void Constructor()
        {
            var result = new ClienteController(_service);
            ClienteDto dto = GenerateFakerClienteDto.CreateClienteDto();
            result.Should().NotBeNull();
        }
        [Fact]
        public void ListAll()
        {
            ClienteDto dto = GenerateFakerClienteDto.CreateClienteDto();
            var result = _controller.ListAll();
            result.Should().NotBeNull();
        }
        
        [Fact]
        public void Update()
        {
            ClienteDto dto = GenerateFakerClienteDto.CreateClienteDto();
            var result = _controller.Update(dto);
        }    
    }
}
