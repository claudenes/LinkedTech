using Avaliacao.Domain.Entities;
using Avaliacao.Domain.Interfaces;
using Avaliacao.Infra.Data.Context;

namespace Avaliacao.Infra.Data.Repositories
{
    public class EnderecoRepository : ResourceRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ApplicationDbContext context) : base(context) { }
    }
}
