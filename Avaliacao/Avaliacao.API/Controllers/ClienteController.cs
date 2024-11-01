using Avaliacao.Application.Dtos;
using Avaliacao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;
        public ClienteController(IClienteService service)
        {
            _service = service;
        }
        [HttpGet]
        public Object ListAll()
        {
            return _service.ListAll();
        }
        [HttpPost]
        public Object Create([FromBody] ClienteDto clienteDto)
        {
            return _service.Create(clienteDto);
        }
        [HttpPut]
        public Object Update([FromBody] ClienteDto clienteDto)
        {
            return _service.Update(clienteDto);
        }
        [HttpDelete]
        public Object Delete(int Id)
        {
            return _service.Delete(Id);
        }
    }
}
