using Avaliacao.Application.Dtos;
using Avaliacao.Domain.Entities;

namespace Avaliacao.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDto> Create(ClienteDto cliente);
        Task<ClienteDto> Read(int Id);
        Task<ClienteDto> Update(ClienteDto cliente);
        Task<ClienteDto> Delete(int Id);
        Task<IEnumerable<ClienteDto>> ListAll();
        Task<IEnumerable<ClienteDto>> ListClienteEnderecos();
        Task<ClienteDto> ClienteById(int Id);

    }
}
