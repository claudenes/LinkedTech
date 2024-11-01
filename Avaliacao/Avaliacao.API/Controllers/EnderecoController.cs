using Avaliacao.Application.Dtos;
using Avaliacao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _service;
        public EnderecoController(IEnderecoService service)
        {
            _service = service;
        }
        [HttpGet]
        public Object ListAll()
        {
            return _service.ListAll();
        }
        [HttpPost]
        public Object Create([FromBody] EnderecoDto enderecoDto)
        {
            return _service.Create(enderecoDto);
        }
        [HttpPut]
        public Object Update([FromBody] EnderecoDto enderecoDto)
        {
            return _service.Update(enderecoDto);
        }
        [HttpDelete]
        public Object Delete(int Id)
        {
            return _service.Delete(Id);
        }
    }
}
