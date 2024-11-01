using Avaliacao.Domain.Entities;
using Avaliacao.Domain.Interfaces;
using Avaliacao.Infra.Data.Context;

namespace Avaliacao.Infra.Data.Repositories
{
    public class ClienteRepository : ResourceRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context) { }
    }
}
