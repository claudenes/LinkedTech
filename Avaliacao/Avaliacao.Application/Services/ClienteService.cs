using AutoMapper;
using Avaliacao.Application.Dtos;
using Avaliacao.Application.Interfaces;
using Avaliacao.Domain.Entities;
using Avaliacao.Domain.Interfaces;

namespace Avaliacao.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ClienteDto> Create(ClienteDto cliente)
        {
            return _mapper.Map<ClienteDto>(_repository.Create(_mapper.Map<Cliente>(cliente)));
        }
      
        public async Task<ClienteDto> Delete(int Id)
        {
            return _mapper.Map<ClienteDto>(_repository.Delete(Id));
        }

        public async Task<IEnumerable<ClienteDto>> ListAll()
        {
            return _mapper.Map<IEnumerable<ClienteDto>>(_repository.ReadAll());
        }

        public async Task<ClienteDto> Read(int Id)
        {
            return _mapper.Map<ClienteDto>(_repository.ReadById(Id));
        }

        public async Task<ClienteDto> Update(ClienteDto cliente)
        {
            return _mapper.Map<ClienteDto>(_repository.Update(_mapper.Map<Cliente>(cliente)));
        }
    }
}
