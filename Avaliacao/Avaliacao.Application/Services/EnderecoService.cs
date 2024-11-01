using AutoMapper;
using Avaliacao.Application.Dtos;
using Avaliacao.Application.Interfaces;
using Avaliacao.Domain.Entities;
using Avaliacao.Domain.Interfaces;

namespace Avaliacao.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;
        private readonly IMapper _mapper;

        public EnderecoService(IEnderecoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EnderecoDto> Create(EnderecoDto endereco)
        {
            return _mapper.Map<EnderecoDto>(_repository.Create(_mapper.Map<Endereco>(endereco)));
        }
      
        public async Task<EnderecoDto> Delete(int Id)
        {
            return _mapper.Map<EnderecoDto>(_repository.Delete(Id));
        }

        public async Task<IEnumerable<EnderecoDto>> ListAll()
        {
            return _mapper.Map<IEnumerable<EnderecoDto>>(_repository.ReadAll());
        }

        public async Task<EnderecoDto> Read(int Id)
        {
            return _mapper.Map<EnderecoDto>(_repository.ReadById(Id));
        }

        public async Task<EnderecoDto> Update(EnderecoDto endereco)
        {
            return _mapper.Map<EnderecoDto>(_repository.Update(_mapper.Map<Endereco>(endereco)));
        }
    }
}
