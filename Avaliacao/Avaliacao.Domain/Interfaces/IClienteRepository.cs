using Avaliacao.Domain.Entities;

namespace Avaliacao.Domain.Interfaces
{
    public interface IClienteRepository : IResourceRepository<Cliente>
    {
        IEnumerable<Cliente> ListClienteEnderecos();
        Cliente ClienteById(int Id);
    }
}
