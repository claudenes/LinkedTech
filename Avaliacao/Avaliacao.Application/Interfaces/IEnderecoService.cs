using Avaliacao.Application.Dtos;

namespace Avaliacao.Application.Interfaces
{
    public interface IEnderecoService
    {
        Task<EnderecoDto> Create(EnderecoDto endereco);
        Task<EnderecoDto> Read(int Id);
        Task<EnderecoDto> Update(EnderecoDto endereco);
        Task<EnderecoDto> Delete(int Id);
        Task<IEnumerable<EnderecoDto>> ListAll();

    }
}
