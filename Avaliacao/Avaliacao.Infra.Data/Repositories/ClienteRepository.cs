using Avaliacao.Domain.Entities;
using Avaliacao.Domain.Interfaces;
using Avaliacao.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Avaliacao.Infra.Data.Repositories
{
    public class ClienteRepository : ResourceRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context) { }
        public IEnumerable<Cliente> ListClienteEnderecos()
        {
            List<Cliente> list = _db.Set<Cliente>()
                .Include(x=>x.Enderecos)
                .ToList();

            return list;
        }
        public Cliente ClienteById(int Id)
        {
            Cliente cliente = _db.Set<Cliente>()
                .Include(x => x.Enderecos)
                .Where(x => x.Id == Id).FirstOrDefault();
                

            return cliente;
        }
    }
}
